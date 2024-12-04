using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;
using voluntariatApp.domain.enums;

namespace voluntariatApp.repo
{
	internal class TypeMatching<E, ID> where E : Entity<ID>
	{
		public static string returnTableName (Type type)
		{
			if (type == typeof(User))
			{
				return "User";
			}
			else if (type == typeof(Organiser))
			{
				return "Organizator";
			}
			else if (type == typeof(LoginEntity))
			{
				return "Logins";
			}
			else if (type == typeof(Event))
			{
				return "Eveniment";
			}
			else if (type == typeof(EventSignup))
			{
				return "Inscriere";
			}
			else if (type == typeof(Participation))
			{
				return "Participare";
			}
			else throw new ArgumentException("Invalid entity type " + type.Name);
		}

		public static E? createEntityFromList (Type type, List<string> parameters)
		{
			if (type == typeof(User))
			{
				return new User(
					parameters[0],
					parameters[1],
					(Occupation)Enum.Parse(typeof(Occupation), parameters[3])
				) as E;
			}
			else if (type == typeof(Organiser))
			{
				return new Organiser(
					parameters[0],
					parameters[1],
					(OrganiserType)Enum.Parse(typeof(OrganiserType), parameters[2]),
					parameters[3]
				) as E;
			}
			else if (type == typeof(LoginEntity))
			{
				return new LoginEntity(
					parameters[0],
					parameters[1],
					parameters[2],
					parameters[3],
					parameters[4]
				) as E;
			}
			else if (type == typeof(Event))
			{
				return new Event(
					long.Parse(parameters[0]),
					parameters[1],
					parameters[2],
					int.Parse(parameters[3]),
					new Location(parameters[4].Split(";")),
					new EventPeriod(DateTime.Parse(parameters[5]), DateTime.Parse(parameters[6])),
					parameters[7],
					parameters[8]
				) as E;
			}
			else if (type == typeof(EventSignup))
			{
				return new EventSignup(
					parameters[0],
					long.Parse(parameters[1]),
					DateTime.Parse(parameters[2]),
					bool.Parse(parameters[3]),
					parameters[4]
				) as E;
			}
			else if (type == typeof(Participation))
			{
				return new Participation(
					parameters[0],
					long.Parse(parameters[1]),
					bool.Parse(parameters[2]),
					parameters[3]
				) as E;
			}
			else throw new ArgumentException("Invalid entity type " + type.Name);
		}

		public static List<string> createListFromEntity (E Entity)
		{
			var resultList = new List<string>();

			if (Entity is User user)
			{
				resultList.Add(user.Cnp);
				resultList.Add(user.Name);
				resultList.Add("");
				resultList.Add(user.Occupation.ToString());
			}
			else if (Entity is Organiser organiser)
			{
				resultList.Add(organiser.Cui);
				resultList.Add(organiser.Name);
				resultList.Add(organiser.Field.ToString());
				resultList.Add(organiser.Description);
			}
			else if (Entity is LoginEntity loginEntity)
			{
				resultList.Add(loginEntity.getId());
				resultList.Add(loginEntity.Username);
				resultList.Add(loginEntity.Password);
				resultList.Add(loginEntity.PhoneNumber);
				resultList.Add(loginEntity.Email);
			}
			else if (Entity is Event eventEntity)
			{
				resultList.Add(eventEntity.getId().ToString());
				resultList.Add(eventEntity.Name);
				resultList.Add(eventEntity.CuiOrganiser);
				resultList.Add(eventEntity.NumberOfParticipants.ToString());
				resultList.Add(eventEntity.Location.ToString());
				resultList.Add(eventEntity.Period.StartDate.ToString("yyyy-MM-dd"));
				resultList.Add(eventEntity.Period.EndDate.ToString("yyyy-MM-dd"));
				resultList.Add(eventEntity.ParticipationRequirements);
				resultList.Add(eventEntity.EventDescription);
			}
			else if (Entity is EventSignup eventSignup)
			{
				resultList.Add(eventSignup.getId().Item1);
				resultList.Add(eventSignup.getId().Item2.ToString());
				resultList.Add(eventSignup.SignupDateTime.ToString("yyyy-MM-dd"));
				resultList.Add(eventSignup.Accepted.ToString());
				resultList.Add(eventSignup.Reason);
			}
			else if (Entity is Participation participation)
			{
				resultList.Add(participation.getId().Item1);
				resultList.Add(participation.getId().Item2.ToString());
				resultList.Add(participation.Present.ToString());
				resultList.Add(participation.Feedback);
			}
			else
				throw new ArgumentException("Invalid entity type " + Entity.GetType().Name);

			return resultList;
		}
	}
}
