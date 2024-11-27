using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;

namespace voluntariatApp.service
{
	internal class Service
	{
		public Service() { }

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
