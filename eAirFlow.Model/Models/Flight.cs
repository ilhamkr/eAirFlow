using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Flight
    {
        public int FlightId { get; set; }

        public string? DepartureLocation { get; set; }

        public string? ArrivalLocation { get; set; }

        public DateTime? DepartureTime { get; set; }

        public DateTime? ArrivalTime { get; set; }
        public string? DepartureTimeZone { get; set; }
        public string? ArrivalTimeZone { get; set; }

        public int? AirlineId { get; set; }

        public int? AirplaneId { get; set; }

        public int? Price { get; set; }

        public string? StateMachine { get; set; }

        public Airline Airline { get; set; }


    }
}
