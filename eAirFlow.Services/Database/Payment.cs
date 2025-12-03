using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? UserId { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionReference { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual User? User { get; set; }
}
