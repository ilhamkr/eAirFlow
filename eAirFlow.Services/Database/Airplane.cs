using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Airplane
{
    public int AirplaneId { get; set; }

    public string? Model { get; set; }

    public int? TotalSeats { get; set; }
    public int? AirlineId { get; set; }
    public virtual Airline? Airline { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
