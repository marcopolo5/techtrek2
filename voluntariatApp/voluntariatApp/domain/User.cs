using voluntariatApp.domain.enums;
using voluntariatApp.validator;

namespace voluntariatApp.domain
{
    internal class User : LoginEntity
    {
        public string Cnp { get; private set; }
        public string Name { get; private set; }
        public Occupation Occupation { get; private set; }

        public User(string name, string cnp, string username, string password, string phoneNumber, string email, Occupation occupation)
            : base(username, password, phoneNumber, email)
        {
            Validator.ValidateName(name);
            Validator.ValidateCnp(cnp);
            Validator.ValidateOccupation(occupation);
            Validator.ValidatePhoneNumber(phoneNumber);
            Validator.ValidateEmail(email);

            Cnp = cnp;
            Name = name;
            Occupation = occupation;
            setId(cnp);
        }

        public override string ToString()
        {
            return $"User: {Name}, Occupation: {Occupation}";
        }
    }
}
