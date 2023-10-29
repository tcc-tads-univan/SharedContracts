using SharedContracts.Events;

namespace SharedContracts
{
    public class InviteRideEvent : BaseEvent
    {
        public int StudentId { get; set; }
    }
}
