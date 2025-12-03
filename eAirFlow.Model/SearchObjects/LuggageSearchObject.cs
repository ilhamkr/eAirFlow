using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class LuggageSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public string? DescriptionContains { get; set; }
        public string? Status { get; set; }
    }
}
