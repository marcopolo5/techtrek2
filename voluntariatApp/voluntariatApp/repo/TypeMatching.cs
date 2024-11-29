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

			}
			else if (type == typeof(Event))
			{

			}
			else if (type == typeof(EventSignup))
			{

			}
			else if (type == typeof(Participation))
			{

			}
			else throw new ArgumentException("Invalid entity type " + type.Name);
			return null;
		}
	}
}
