using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal class Organiser : LoginEntity
	{
		private string Cui;
		private string Name;
		private string Tip; //To make Enum type
		private string Description;
		public Organiser(string cui, string name, string tip, string description, string username, string password, string phoneNumber, string email) 
			: base(username, password, phoneNumber, email)
		{
			this.Cui = cui;
			this.setId(cui);
			this.Name = name;
			this.Tip = tip;
			this.Description = description;
		}
	}
}
