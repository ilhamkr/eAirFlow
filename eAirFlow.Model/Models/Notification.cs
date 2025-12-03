using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Notification
    {
        public int NotificationId { get; set; }

        public int? UserId { get; set; }

        public string? Message { get; set; }

        public DateTime? SentAt { get; set; }
        public User? User { get; set; }
        public bool IsSeen { get; set; }


    }
}
