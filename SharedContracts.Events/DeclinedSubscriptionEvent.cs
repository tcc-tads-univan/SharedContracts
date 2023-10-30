﻿using SharedContracts.Events;

namespace SharedContracts
{
    public class DeclinedSubscriptionEvent : BaseUnivanEvent
    {
        public int DriverId { get; set; }
        public int StudentId { get; set; }
    }
}
