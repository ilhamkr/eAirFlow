using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class AirlineUpdateRequest
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int AirportId { get; set; }
    }
}
