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
