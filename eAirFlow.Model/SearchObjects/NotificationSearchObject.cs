using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class NotificationSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public bool? UnreadOnly { get; set; }
        public bool IsSeen { get; set; }

    }
}
