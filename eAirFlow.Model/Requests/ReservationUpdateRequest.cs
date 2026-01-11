using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class ReservationUpdateRequest
    {
        public int? UserId { get; set; }
        public int? FlightId { get; set; }
        public DateTime? ReservationDate { get; set; }
        public int? PaymentId { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PassportNumber { get; set; }
        public string? Citizenship { get; set; }
        public string? BaggageInfo { get; set; }
    }
}
