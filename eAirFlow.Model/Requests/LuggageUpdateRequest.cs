using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class LuggageUpdateRequest
    {
        public int? UserId { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
