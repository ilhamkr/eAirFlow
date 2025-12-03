using System;
using System.Collections.Generic;

namespace eAirFlow.Services.Database;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? PhoneNumber { get; set; }

    public string? ProfileImageUrl { get; set; }


    public DateTime? CreatedAt { get; set; }

    public string? PasswordSalt { get; set; }

    public virtual ICollection<FlightReview> FlightReviews { get; set; } = new List<FlightReview>();

    public virtual ICollection<Luggage> Luggage { get; set; } = new List<Luggage>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    public virtual Employee? Employee { get; set; }
}
