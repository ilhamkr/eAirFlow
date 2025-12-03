using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class FlightReviewSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public int? MinRating { get; set; }
        public int? MaxRating { get; set; }
    }
}
