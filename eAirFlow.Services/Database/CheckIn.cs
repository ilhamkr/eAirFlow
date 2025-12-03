using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class CheckIn
{
    public int CheckinId { get; set; }

    public int? ReservationId { get; set; }

    public int? SeatId { get; set; }

    public DateTime? CheckinTime { get; set; }

    public virtual Reservation? Reservation { get; set; }

    public virtual Seat? Seat { get; set; }

    public string? StateMachine {  get; set; }
    public int? UserId { get; set; }
    public virtual User? User { get; set; }
}
