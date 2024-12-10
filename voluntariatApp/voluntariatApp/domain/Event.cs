namespace voluntariatApp.domain
{
    internal class Event : Entity<long>
    {
        public string Name { get; private set; }
        public string CuiOrganiser { get; private set; }
        public int NumberOfParticipants { get; private set; }
        public Location Location { get; private set; }
        public EventPeriod Period { get; private set; }
        public string ParticipationRequirements { get; private set; }
        public string EventDescription { get; private set; }
        public List<EventSignup> SignupList { get; init; } = new List<EventSignup>();
        public List<Participation> ParticipationList { get; init; } = new List<Participation>();

        public Event(
            long id,
            string name,
            string cuiOrganiser,
            int numberOfParticipants,
            Location location,
            EventPeriod period,
            string participationRequirements,
            string eventDescription)
        {
            Name = name;
            CuiOrganiser = cuiOrganiser;
            NumberOfParticipants = numberOfParticipants;
            Location = location;
            Period = period;
            ParticipationRequirements = participationRequirements;
            EventDescription = eventDescription;
            this.ParticipationRequirements = participationRequirements;
            this.EventDescription = eventDescription;
            this.setId(id);
        }
        public override string ToString()
        {
            return $"{Name} ({Period.StartDate:yyyy-MM-dd} to {Period.EndDate:yyyy-MM-dd}) at {Location}";
        }
    }
}
