using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain.enums;

namespace voluntariatApp.domain
{
    internal class Organiser : LoginEntity
	{
		private string Cui;
		private string Name;
		private OrganiserType OrganiserType; 
		private string Description;
		public Organiser(string cui, string name, OrganiserType organiserType, string description, string username, string password, string phoneNumber, string email) 
			: base(username, password, phoneNumber, email)
		{
			this.Cui = cui;
			this.setId(cui);
			this.Name = name;
			this.OrganiserType = organiserType;
			this.Description = description;
		}
	}
}
