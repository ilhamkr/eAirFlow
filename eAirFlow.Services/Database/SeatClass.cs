using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class SeatClass
{
    public int SeatClassId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();
}
