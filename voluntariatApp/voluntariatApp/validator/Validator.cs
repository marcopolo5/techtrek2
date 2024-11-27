namespace voluntariatApp.validator
{
    public static class Validator
    {
        public static void ValidateCnp(string cnp)
        {
            if (string.IsNullOrWhiteSpace(cnp))
                throw new ArgumentException("CNP cannot be null or empty.");
            if (cnp.Length != 13 || !cnp.All(char.IsDigit))
                throw new ArgumentException("Invalid CNP format. CNP must be 13 digits long.");
        }

        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            if (name.Length < 2 || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                throw new ArgumentException("Invalid name format.");
        }

        public static void ValidateOccupation(object occupation)
        {
            if (occupation == null)
                throw new ArgumentException("Occupation cannot be null.");
        }

        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Invalid email format.");
        }

        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber) || !phoneNumber.All(char.IsDigit))
                throw new ArgumentException("Invalid phone number. Only digits are allowed.");
        }
    }
}
