using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
    internal class LoginEntity : Entity<string>
    {
        public string Username { get; init; }
        public string Password { get; init; }
        public string PhoneNumber { get; init; }
        public string Email { get; init; }

        public LoginEntity(string username, string password, string phoneNumber, string email)
        {
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public LoginEntity(string idCnpOrCui, string username, string password, string phoneNumber, string email)
        {
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.setId(idCnpOrCui);
        }
    }
}