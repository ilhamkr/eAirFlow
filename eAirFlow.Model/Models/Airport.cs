using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string? TimeZoneId { get; set; }

    }
}
