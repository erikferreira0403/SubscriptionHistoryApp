using System;

namespace TestEfCore.Models
{
    public class Subscription
    {
        public Subscription(int id, int userId)
        {
            Id = id;
            UserId = userId;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
