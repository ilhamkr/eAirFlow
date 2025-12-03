using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Airline
    {
        public int AirlineId { get; set; }

        public string? Name { get; set; }

        public string? Country { get; set; }

        public int? AirportId { get; set; }
        public Airport? Airport { get; set; }

        public List<Airplane>? Airplanes { get; set; }

    }

}
