using SharedContracts.Events;

namespace SharedContracts
{
    public class DeclinedRideEvent : BaseCarpoolEvent
    {
        public int StudentId { get; set; }
        public int DriverId { get; set; }
        public string Origin { get; set; }
        public string ScheduleTime { get; set; }
    }
}
