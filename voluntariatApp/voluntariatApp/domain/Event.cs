namespace voluntariatApp.domain
{
    internal class Event
    {
        public string Name { get; private set; }
        public int NumberOfParticipants { get; private set; }
        public Location Location { get; private set; }
        public EventPeriod Period { get; private set; }
        public string ParticipationRequirements { get; private set; }
        public string EventDescription { get; private set; }
        public List<EventSignup> SignupList { get; init; } = new List<EventSignup>();
        public List<Participation> ParticipationList { get; init; } = new List<Participation>();

        public Event(
            string name,
            int numberOfParticipants,
            Location location,
            EventPeriod period,
            string participationRequirements,
            string eventDescription)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Event name cannot be null or empty.");
            if (numberOfParticipants <= 0) throw new ArgumentException("Number of participants must be greater than zero.");

            Name = name;
            NumberOfParticipants = numberOfParticipants;
            Location = location ?? throw new ArgumentNullException(nameof(location));
            Period = period ?? throw new ArgumentNullException(nameof(period));
            ParticipationRequirements = participationRequirements ?? string.Empty;
            EventDescription = eventDescription ?? string.Empty;
            this.ParticipationRequirements = participationRequirements;
            this.EventDescription = eventDescription;
        }
        public override string ToString()
        {
            return $"{Name} ({Period.StartDate:yyyy-MM-dd} to {Period.EndDate:yyyy-MM-dd}) at {Location}";
        }
    }
}
