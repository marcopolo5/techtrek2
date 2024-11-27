namespace voluntariatApp.domain
{
    public class EventPeriod
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public EventPeriod(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate) throw new ArgumentException("Start date must be before end date.");
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}