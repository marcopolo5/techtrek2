using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain.Enums;

namespace voluntariatApp.domain
{
	internal class User : LoginEntity
	{
		private string Cnp { get; init; }
		private string Name { get; init; }
		private int Age { get; init; }
		private TypeOcupation Ocupation { get; init; } 
		public User(string name, string cnp, TypeOcupation ocupation, string username, string password, string phoneNumber, string email) 
			: base(username, password, phoneNumber, email)
		{
			this.Cnp = cnp;
			this.Name = name;
			this.Ocupation = ocupation;
			this.setId(cnp);
		}
	}
}
