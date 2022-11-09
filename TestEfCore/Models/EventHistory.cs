using System;

namespace TestEfCore.Models
{
    public class EventHistory
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
