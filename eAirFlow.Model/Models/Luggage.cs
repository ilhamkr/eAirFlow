using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Luggage
    {
        public int LuggageId { get; set; }

        public int? UserId { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string? StateMachine { get; set; }

        public int? AirportId { get; set; }
        public Airport? Airport { get; set; }
        public User? User { get; set; }



    }
}
