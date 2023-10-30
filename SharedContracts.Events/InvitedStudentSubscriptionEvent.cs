namespace SharedContracts.Events
{
    public class InvitedStudentSubscriptionEvent : BaseUnivanEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
        public decimal MonthlyFee { get; set; }
        public int ExpirationDay { get; set; }
    }
}