using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class FlightReview
    {
        public int ReviewId { get; set; }

        public int? UserId { get; set; }

        public int? FlightId { get; set; }

        public int? Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime? SubmittedAt { get; set; }

        public Flight? Flight { get; set; }
    }
}
