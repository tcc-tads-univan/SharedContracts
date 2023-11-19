namespace SharedContracts.Events
{
    public class CompleteTripEvent : BaseCarpoolEvent
    {
        public int ScheduleId { get; set; }
    }
}
