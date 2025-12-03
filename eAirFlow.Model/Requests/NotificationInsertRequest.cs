using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class NotificationInsertRequest
    {
        public int? UserId { get; set; }
        public string? Message { get; set; }
        public DateTime? SentAt { get; set; }
    }
}
