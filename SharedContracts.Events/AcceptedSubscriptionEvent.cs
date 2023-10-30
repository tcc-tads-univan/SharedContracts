using SharedContracts.Events;

namespace SharedContracts
{
    public class AcceptedSubscriptionEvent : BaseUnivanEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
    }
}
