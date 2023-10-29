using SharedContracts.Events;

namespace SharedContracts
{
    public class AcceptedSubscriptionEvent : BaseEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
    }
}
