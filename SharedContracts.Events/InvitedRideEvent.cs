using SharedContracts.Events;

namespace SharedContracts
{
    public class InvitedRideEvent : BaseCarpoolEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
        public string ScheduleTime { get; set; }
        public decimal RidePrice { get; set; }
    }
}
