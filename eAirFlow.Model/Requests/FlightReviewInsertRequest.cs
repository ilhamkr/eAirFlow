using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class FlightReviewInsertRequest
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }
    }
}
