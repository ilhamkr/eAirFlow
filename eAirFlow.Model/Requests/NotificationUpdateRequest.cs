using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class NotificationUpdateRequest
    {
        public int? UserId { get; set; }
        public string? Message { get; set; }
        public DateTime? SentAt { get; set; }

        public bool? IsSeen { get; set; }
    }
}
