namespace voluntariatApp.domain
{
    public class Location
    {
        public string State { get; private set; }
        public string City { get; private set; }
        public string StreetName { get; private set; }
        public string StreetNumber { get; private set; }

        public Location(string state, string city, string streetName, string streetNumber)
        {
            if (string.IsNullOrWhiteSpace(state)) throw new ArgumentException("State cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(streetName)) throw new ArgumentException("Street name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(streetNumber)) throw new ArgumentException("Street number cannot be null or empty.");

            State = state;
            City = city;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public override string ToString()
        {
            return $"{StreetNumber} {StreetName}, {City}, {State}";
        }
    }
}
