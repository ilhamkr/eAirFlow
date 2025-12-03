using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class AirlineInsertRequest
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int AirportId { get; set; }
    }
}
