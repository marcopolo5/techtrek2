using voluntariatApp.domain;
using voluntariatApp.service;

namespace voluntariatApp.controller
{
    internal class Controller
    {
        private static Controller? instance = null;
        private LoginEntity? loggedInEntity;
        private Service service;

        private Controller()
        {
            this.service = new Service("Host=ep-soft-darkness-a9t94gzc.gwc.azure.neon.tech;Database=Voluntariat;Username=Voluntariat_owner;Password=YV2LJcNsgd3u;SSL Mode=Require;Trust Server Certificate=true");
        }
        public static Controller getInstance()
        {
            if (instance == null)
                instance = new Controller();
            return instance;
        }
        public void addLogin(List<string> param) => loggedInEntity = new LoginEntity(param[0], param[1], param[2], param[3]);
        public void signUpOrganizator(List<string> param)
        {
            try
            {
                service.addOrganiser(param[0], param[1], param[2], param[3], loggedInEntity.Username, loggedInEntity.Email, loggedInEntity.Password, loggedInEntity.PhoneNumber);
            }
            catch (Exception _)
            {
                this.loggedInEntity = null;
            }
        }
        public void signUpUser(List<string> param)
        {
            try
            {
                service.addUser(param[0], param[1], param[2], loggedInEntity.Username, loggedInEntity.Password, loggedInEntity.Email, loggedInEntity.PhoneNumber);
            }
            catch (Exception _)
            {
                this.loggedInEntity = null;
            }
        }

        public bool login(string username, string password)
        {
            try
            {
                this.loggedInEntity = this.service.login(username, password);
                return true;
            }
            catch (Exception _)
            {
                return false;
            }
        }
        public List<Event> topEvens()
        {
            return service.getPopularEventList();
        }

        public List<Event> organizationEvents()
        {
            return service.listaEvenimenteOrganizatie(loggedInEntity.getId());
        }

        public bool isUser()
        {
            if (loggedInEntity != null)
            {
                return service.getUser(loggedInEntity.getId()) != null;
            }
            else
            {
                MessageBox.Show("date invalide");
                return false;
            }

        }
        public void addEvent(List<string> param)
        {

            DateTime dateTime = DateTime.ParseExact(param[3], "MM/dd/yyyy", null);
            dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0);

            DateTime dateTime2 = DateTime.ParseExact(param[4], "MM/dd/yyyy", null);
            dateTime2 = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0);
            service.addEvent(14,loggedInEntity.getId(),param[0], int.Parse(param[1]), new Location(param[2]),new EventPeriod(dateTime, dateTime2), param[5], param[6]);
        }
        public void deleteEvent(long id)
        {
            try
            {
                service.deleteEvent(id);
            }
            catch (Exception _)
            {
            }
        }
    }
}