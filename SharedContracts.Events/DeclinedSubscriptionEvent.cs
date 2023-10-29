using SharedContracts.Events;

namespace SharedContracts
{
    public class DeclinedSubscriptionEvent : BaseEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
    }
}
