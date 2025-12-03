using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Luggage
{
    public int LuggageId { get; set; }

    public int? UserId { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string? StateMachine { get; set; }

    public virtual ICollection<LuggageReport> LuggageReports { get; set; } = new List<LuggageReport>();

    public virtual User? User { get; set; }

    public int? AirportId { get; set; }
    public Airport? Airport { get; set; }

}
