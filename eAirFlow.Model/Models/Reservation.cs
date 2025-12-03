using System;
using System.Collections.Generic;
using System.Linq;

namespace eAirFlow.Model.Models
{

    public class Reservation
    {
        public int ReservationId { get; set; }

        public int? UserId { get; set; }

        public int? FlightId { get; set; }
        public int? AirportId { get; set; }
        public int? AirplaneId { get; set; }

        public DateTime? ReservationDate { get; set; }

        public int? PaymentId { get; set; }

        public string? StateMachine { get; set; }
        public int? SeatId { get; set; }
        public Seat? Seat { get; set; }

        public int? SeatClassId { get; set; }
        public SeatClass? SeatClass { get; set; }

        public int? MealTypeId { get; set; }
        public MealType? MealType { get; set; }
        public string? QrCodeBase64 { get; set; }

        public Flight? Flight { get; set; }
        public Airport? Airport { get; set; }
        public Payment? Payment { get; set; }
        public CheckIn? CheckIn { get; set; }
        public Airplane? Airplane { get; set; }




    }
}
