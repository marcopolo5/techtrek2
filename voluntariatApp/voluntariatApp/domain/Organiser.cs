using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain.enums;

namespace voluntariatApp.domain
{
    internal class Organiser : LoginEntity
    {
        private string Cui { get; init; }
        private string Name { get; init; }
        private OrganiserType Field { get; init; }
        private string Description { get; init; }
        public Organiser(string cui, string name, OrganiserType field, string description, string username, string password, string phoneNumber, string email)
            : base(username, password, phoneNumber, email)
        {
            this.Cui = cui;
            this.setId(cui);
            this.Name = name;
            this.Field = field;
            this.Description = description;
        }

        public Organiser(string cui, string name, OrganiserType field, string description)
			: base("default", "default", "default", "default")
        {
            this.Cui = cui;
            this.Name= name;
            this.Field = field;
            this.Description = description;
        }

	}
}