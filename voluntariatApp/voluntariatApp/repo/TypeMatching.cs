using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;

namespace voluntariatApp.repo
{
	internal static class TypeMatching
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


	}
}
