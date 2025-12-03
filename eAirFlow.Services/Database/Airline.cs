using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Airline
{
    public int AirlineId { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public int? AirportId { get; set; }
    public Airport? Airport { get; set; }

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
}
