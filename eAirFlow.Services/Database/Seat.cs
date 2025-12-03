using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Seat
{
    public int SeatId { get; set; }

    public int? AirplaneId { get; set; }

    public string? SeatNumber { get; set; }

    public int? SeatClassId { get; set; }

    public virtual Airplane? Airplane { get; set; }

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual SeatClass? SeatClass { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
