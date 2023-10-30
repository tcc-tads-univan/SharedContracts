using SharedContracts.Events;

namespace SharedContracts
{
    public class CreatedUserEvent : BaseUnivanEvent
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
