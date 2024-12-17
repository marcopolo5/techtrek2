using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using voluntariatApp.domain;
using voluntariatApp.domain.enums;
using voluntariatApp.repo;
using voluntariatApp.validator;

namespace voluntariatApp.service
{
    internal class Service
    {
        public Repository<User, string> userRepo;
        private Repository<Organiser, string> organiserRepo;
        private Repository<LoginEntity, string> loginRepo;
        private Repository<Event, long> eventRepo;
        private Repository<Participation, Tuple<string, long>> participationRepo;
        private Repository<EventSignup, Tuple<string, long>> signupRepo;

        public Service(string connectionString)
        {
            this.userRepo = new Repository<User, string>(connectionString);
            this.organiserRepo = new Repository<Organiser, string>(connectionString);
            this.loginRepo = new Repository<LoginEntity, string>(connectionString);
            this.eventRepo = new Repository<Event, long>(connectionString);
            this.participationRepo = new Repository<Participation, Tuple<string, long>>(connectionString);
            this.signupRepo = new Repository<EventSignup, Tuple<string, long>>(connectionString);
        }

        private void addLogin(string username, string password, string email, string phone, string id)
        {
            if (!Validator.IsValidPassword(password))
                throw new ArgumentException("Invalid password.");
            if (!Validator.IsValidEmail(email))
                throw new ArgumentException("Invalid email.");

            this.loginRepo.Save(
                new LoginEntity(id, username, password, email, phone)
            );
        }

        public LoginEntity? getLogin(string id) => this.loginRepo.Find(id);

        public void addUser(string cnp, string name, string occupation, string username, string password, string email, string phone)
        {
            if (!Validator.IsValidName(name)) throw new ArgumentException("Invalid name");
            if (!Validator.IsValidCNP(cnp)) throw new ArgumentException("Invalid cnp");
            if (!Validator.IsValidOccupation(occupation)) throw new ArgumentException("Invalid occupation");

            this.addLogin(username, password, email, phone, cnp);
            this.userRepo.Save(
                new User(name, cnp, username, password, phone, email, (Occupation)Enum.Parse(typeof(Occupation), occupation))
            );
        }

        public User? getUser(string cnp) => this.userRepo.Find(cnp);

        public IEnumerable<User> getUserList() => this.userRepo.FindAll();

        public void addSignup(string cnp, long idEvent, string reason)
        {
            if (this.userRepo.Find(cnp) == null)
                throw new ArgumentException("User with given cnp not found.");
            if (this.eventRepo.Find(idEvent) == null)
                throw new ArgumentException("Event with given id not found.");

            this.signupRepo.Save(new EventSignup(
                    cnp, idEvent, DateTime.Now, false, reason
            ));
        }

        public void deleteSignup(string cnp, long idEvent) => this.signupRepo.Delete(Tuple.Create(cnp, idEvent));

        public EventSignup? getEventSignup(string cnp, long idEvent) => this.signupRepo.Find(Tuple.Create(cnp, idEvent));

        public IEnumerable<EventSignup> getEventSignupList() => this.signupRepo.FindAll();

        public void addOrganiser(string cui, string name, string field, string description, string username, string email, string password, string phone)
        {
            if (!Validator.IsValidName(name)) throw new ArgumentException("Invalid name");
            if (!Validator.IsValidCUI(cui)) throw new ArgumentException("Invalid cui");
            this.addLogin(username, password, email, phone, cui);
            this.organiserRepo.Save(
                new Organiser(cui, name, (OrganiserType)Enum.Parse(typeof(OrganiserType), field), description, username, password, phone, email)
            );
        }

        public void deleteUserOrganiser(string id, string password)
        {
            //Sterge un user sau organizator. doar login-ul, user/organizator nu se va mai putea loga,
            //dar contul inca exista
            if (this.loginRepo.Find(id)!.Password == password)
                this.loginRepo.Delete(id);
        }

        public Organiser? getOrganiser(string cui) => this.organiserRepo.Find(cui);

        public void addEvent(long idEvent, string name, string cui, int numberOfParticipants, Location location, EventPeriod eventPeriod, string requirements, string description)
        {
            if (!Validator.IsValidEventName(name))
                throw new ArgumentException("Invalid name.");
            if (!Validator.IsValidEventPeriod(eventPeriod))
                throw new ArgumentException("Invalid event period.");
            if (!Validator.IsValidNumberOfParticipants(numberOfParticipants, 1000))
                throw new ArgumentException("Invalid number of participants.");
            if (!Validator.IsValidLocation(location))
                throw new ArgumentException("Invalid location.");
            if (!Validator.IsValidParticipationRequirements(requirements))
                throw new ArgumentException("Invalid requirements.");
            if (!Validator.IsValidEventDescription(description))
                throw new ArgumentException("Invalid description.");

            this.eventRepo.Save(
                new Event(idEvent, name, cui, numberOfParticipants, location, eventPeriod, requirements, description)
            );

        }

        public void deleteEvent(long id)
        {
            if (this.eventRepo.Find(id)!.Period.EndDate < DateTime.UtcNow)
                throw new ArgumentException("Nu poti sterge un eveniment deja incheiat.");

            List<Tuple<string, long>> toDelete = new List<Tuple<string, long>>();

            foreach (var signup in this.signupRepo.FindAll())
                if (signup.getId().Item2 == id)
                    toDelete.Add(signup.getId());

            toDelete.ForEach(x => this.signupRepo.Delete(x));
            this.eventRepo.Delete(id);
        }

        public Event? getEvent(long id) => this.eventRepo.Find(id);

        public IEnumerable<Event> getEventList() => this.eventRepo.FindAll();

        public List<Event> getPopularEventList() =>
            this.eventRepo.FindAll()
                .Where(e => e.NumberOfParticipants -
                    this.signupRepo.FindAll().Count(s => s.getId().Item2 == e.getId())
                    < e.NumberOfParticipants / 10)
                .ToList();

        public void addParticipation(string cnp, long id, bool present, string feedback)
        {
            if (this.userRepo.Find(cnp) == null)
                throw new ArgumentException("User with given cnp doesn't exist.");
            if (this.eventRepo.Find(id) == null)
                throw new ArgumentException("Event with given id doesn't exist.");

            this.participationRepo.Save(
                new Participation(cnp, id, present, feedback)
            );
        }
        public void deleteParticipation(string cnp, long id) => this.participationRepo.Delete(Tuple.Create(cnp, id));

        public LoginEntity? login(string username, string password)
        {
            LoginEntity loginEntity = this.loginRepo.FindAll().First(l => l.Username == username);
            if (loginEntity.Password == password && loginEntity != null)
                return loginEntity;
            return null;
        }
    }
}