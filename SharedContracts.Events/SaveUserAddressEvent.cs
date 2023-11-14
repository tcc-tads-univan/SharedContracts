namespace SharedContracts.Events
{
    public class SaveUserAddressEvent : BaseUnivanEvent
    {
        public int UserId { get; set; }
        public String PlaceId { get; set; }
        public int? RelatedTo { get; set; }
    }
}
