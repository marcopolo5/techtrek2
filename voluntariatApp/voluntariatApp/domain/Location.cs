using static System.Windows.Forms.AxHost;

namespace voluntariatApp.domain
{
    public class Location
    {
		private string[] strings;

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

		public Location(string[] strings)
		{
			State = strings[0];
			City = strings[1];
			StreetName = strings[2];
			StreetNumber = strings[3];
		}

		public override string ToString()
        {
            return $"{State};{City};{StreetName};{StreetNumber}";
        }
	}
}
