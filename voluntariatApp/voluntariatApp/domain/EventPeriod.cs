namespace voluntariatApp.domain
{
    public class EventPeriod
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public EventPeriod(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}