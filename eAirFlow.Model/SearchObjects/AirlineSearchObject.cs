using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class AirlineSearchObject : BaseSearchObject
    {
        public string? NameGTE { get; set; }
        public string? CountryGTE { get; set; }
        public int? AirportId { get; set; }
    }
}
