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
            Cnp = cnp;
            Name = name;
            Occupation = occupation;
            setId(cnp);
        }
        
        public User(string cnp, string name, Occupation occupation)
            : base("default", "default", "default", "default")
        {
            this.Name = name;
            this.Cnp = cnp;
            this.Occupation = occupation;
            setId(cnp);
        }

        public override string ToString()
        {
            return $"Cnp: {Cnp}, User: {Name}, Occupation: {Occupation}";
        }
    }
}
