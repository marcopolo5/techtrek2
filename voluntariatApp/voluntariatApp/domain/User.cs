using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal class User : LoginEntity
	{
		private string Cnp;
		private string Name;
		private int Age;
		private string Ocupatie; //To make enum 
		public User(string name, string cnp, string username, string password, string phoneNumber, string email) 
			: base(username, password, phoneNumber, email)
		{
			this.Cnp = cnp;
			this.Name = name;
			this.setId(cnp);
		}


	}
}
