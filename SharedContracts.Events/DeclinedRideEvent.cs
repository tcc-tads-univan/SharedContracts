using SharedContracts.Events;

namespace SharedContracts
{
    public class DeclinedRideEvent : BaseEvent
    {
        public int DriverId { get; set; }
    }
}
