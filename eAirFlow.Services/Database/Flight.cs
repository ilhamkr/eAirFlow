using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Flight
{
    public int FlightId { get; set; }

    public string? DepartureLocation { get; set; }

    public string? ArrivalLocation { get; set; }

    public DateTime? DepartureTime { get; set; }

    public DateTime? ArrivalTime { get; set; }
    public string? DepartureTimeZone { get; set; }
    public string? ArrivalTimeZone { get; set; }

    public int? AirlineId { get; set; }

    public int? AirplaneId { get; set; }

     public string? StateMachine { get; set; }

    public int? Price { get; set; }

    public virtual Airline? Airline { get; set; }

    public virtual ICollection<FlightReview> FlightReviews { get; set; } = new List<FlightReview>();

    public virtual ICollection<Luggage> Luggage { get; set; } = new List<Luggage>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
