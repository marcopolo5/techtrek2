using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;
using voluntariatApp.repo;

namespace voluntariatApp.service
{
	internal class Service
	{
		private Repository<User, string> userRepo;
		private Repository<Organiser, string> organiserRepo;
		private Repository<LoginEntity, string> loginRepo;
		private Repository<Event, long> eventRepo;
		private Repository<Participation, Tuple<string, long>> participationRepo;
		private Repository<EventSignup, Tuple<string, long>> signupRepo;

		public Service(string connectionString) {
			this.userRepo = new Repository<User, string>(connectionString);
			this.organiserRepo = new Repository<Organiser, string>(connectionString);
			this.loginRepo = new Repository<LoginEntity, string>(connectionString);
			this.eventRepo = new Repository<Event, long>(connectionString);
			this.participationRepo = new Repository<Participation, Tuple<string, long>>(connectionString);
			this.signupRepo = new Repository<EventSignup, Tuple<string, long>>(connectionString);
		}

		public void addLogin()
		{

		}

		public void deleteLogin()
		{

		}

		public void addUser ()
		{
			this.addLogin();
			// TODO: to validate user
		}

		public void deleteUser()
		{
			this.deleteLogin();
		}

		public User getUser ()
		{
			return null!;
		}

		public List<User> getUserList()
		{
			return null!;
		}

		public void addSignup()
		{

		}

		public void deleteSignup()
		{

		}

		public EventSignup getEventSignup()
		{
			return null!;
		}

		public List<EventSignup> getEventSignupList()
		{
			return null!;
		}

		public void addOrganiser()
		{
			this.addLogin();
		}

		public void deleteOrganiser()
		{
			this.deleteLogin();
		}

		public Organiser getOrganiser()
		{
			return null!;
		}

		public void addEvent()
		{

		}

		public void deleteEvent()
		{

		}

		public Event getEvent()
		{
			return null!;
		}

		public List<Event> getEventList()
		{
			return null!;
		}

		public List<Event> getPopularEventList()
		{
			return null!;
		}

		public void addParticipation ()
		{

		}

		public void deleteParticipation ()
		{

		}


	}
}
