using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int? UserId { get; set; }

    public int? FlightId { get; set; }
    public int? AirportId { get; set; }

    public DateTime? ReservationDate { get; set; }
    public int? AirplaneId { get; set; }
    public int? PaymentId { get; set; }

    public string? StateMachine { get; set; }
    public int? SeatId { get; set; }
    public Seat? Seat { get; set; }

    public int? MealTypeId { get; set; }
    public MealType? MealType { get; set; }
    public string? QrCodeBase64 { get; set; }

    public string? DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? PassportNumber { get; set; }
    public string? Citizenship { get; set; }
    public string? BaggageInfo { get; set; }

    public virtual ICollection<CheckIn> CheckIns { get; set; } = new List<CheckIn>();

    public virtual Flight? Flight { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual User? User { get; set; }

    public virtual Airport? Airport { get; set; }
    public virtual Airplane? Airplane { get; set; }


}
