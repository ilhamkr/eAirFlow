using System;
using System.Collections.Generic;

namespace eAirFlow.Model.Models
{

    public class Payment
    {
        public int PaymentId { get; set; }

        public int? UserId { get; set; }

        public decimal? Amount { get; set; }

        public string? PaymentMethod { get; set; }

        public DateTime? TransactionDate { get; set; }

        public string? TransactionReference { get; set; }

    }
}
