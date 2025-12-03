using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class PaymentInsertRequest
    {
        public int? UserId { get; set; }
        public decimal? Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionReference { get; set; }
    }
}
