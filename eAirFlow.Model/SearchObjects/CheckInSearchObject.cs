using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class CheckInSearchObject : BaseSearchObject
    {
        public int? ReservationId { get; set; }
        public int? SeatId { get; set; }
        public int? UserId { get; set; }
    }
}
