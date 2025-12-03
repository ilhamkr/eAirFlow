using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class ReservationSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public int? PaymentId { get; set; }
    }
}
