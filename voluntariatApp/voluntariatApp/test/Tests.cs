using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;
using voluntariatApp.domain.enums;
using voluntariatApp.repo;

namespace voluntariatApp.test
{
	internal class Tests
	{
		public static void TypeMatchingTest ()
		{
			var userParams = new List<string> { "123", "Alex Zdroba", "10", "Angajat" };
			var user = TypeMatching<User, string>.createEntityFromList(typeof(User), userParams);
			Debug.Assert(user != null, "user is null");
			Debug.Assert(user.Name == "Alex Zdroba", "incorrect name");
			Debug.Assert(user.Cnp == "123", "incorrect cnp");
			Debug.Assert(user.Occupation == Occupation.Angajat, "incorrect occupation");

			var organiserParams = new List<string> { "123", "XX", "Social", "description" };
			var organiser = TypeMatching<Organiser, string>.createEntityFromList(typeof(Organiser), organiserParams);
			Debug.Assert(organiser != null, "organiser is null");
			Debug.Assert(organiser.Name == "XX", "incorrect name");
			Debug.Assert(organiser.Field == OrganiserType.Social, "incorrect field");
			Debug.Assert(organiser.Description == "description", "incorrect description");

			var eventParams = new List<string> { "1", "Event1", "cui", "50", "State;City;Street;Nr", "2024-01-01", "2024-01-02", "req", "desc" };
			var evt = TypeMatching<Event, long>.createEntityFromList(typeof(Event), eventParams);
			Debug.Assert(evt != null, "event is null");
			Debug.Assert(evt.getId() == 1, "incorrect id");
			Debug.Assert(evt.Name == "Event1", "incorrect name");
			Debug.Assert(evt.CuiOrganiser == "cui", "incorrect cui");
			Debug.Assert(evt.EventDescription == "desc", "incorrect description");
			Debug.Assert(evt.NumberOfParticipants == 50, "incorrect capacity");
			Debug.Assert(evt.Location.State == "State", "incorrect state");
			Debug.Assert(evt.Location.City == "City", "incorrect city");
			Debug.Assert(evt.Location.StreetName == "Street", "incorrect street");
			Debug.Assert(evt.Location.StreetNumber == "Nr", "Nr");

			//login, participation, event signup
		}

		public static string TestRepositoryUser()
		{
			var repo = new Repository<User, string>();
			string result = "";
			foreach (User user in repo.FindAll())
			{
				//File.AppendAllText(@".\\outputTest.txt", user.ToString() + "\n");
				result += user.ToString() + "\n";
			}
			return result;
		}
		public static void TestAll()
		{
			TypeMatchingTest();
		}
	}
}
