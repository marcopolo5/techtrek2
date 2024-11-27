using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal abstract class LoginEntity : Entity<string>
	{
		protected string Username { get; init; }
		protected string Password { get; init; }
		protected string PhoneNumber { get; init; }
		protected string Email { get; init; }

		public LoginEntity(string username, string password, string phoneNumber, string email)
		{
			this.Username = username;
			this.Password = password;
			this.PhoneNumber = phoneNumber;
			this.Email = email;
		}
	}
}
