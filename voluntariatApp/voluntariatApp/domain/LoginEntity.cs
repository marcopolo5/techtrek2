using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal abstract class LoginEntity : Entity<string>
	{
		private string Username { get; init; }
		private string Password { get; init; }
		private string PhoneNumber { get; init; }
		private string Email { get; init; }

		public LoginEntity(string username, string password, string phoneNumber, string email)
		{
			this.Username = username;
			this.Password = password;
			this.PhoneNumber = phoneNumber;
			this.Email = email;
		}
	}
}
