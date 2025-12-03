using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eAirFlow.Services.Database;

public partial class _210019Context : DbContext
{
    public _210019Context()
    {
    }

    public _210019Context(DbContextOptions<_210019Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<Airplane> Airplanes { get; set; }

    public virtual DbSet<CheckIn> CheckIns { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<FlightReview> FlightReviews { get; set; }

    public virtual DbSet<Luggage> Luggages { get; set; }

    public virtual DbSet<LuggageReport> LuggageReports { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<SeatClass> SeatClasses { get; set; }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }
    public virtual DbSet<EmailConfirmation> EmailConfirmations { get; set; }
    public virtual DbSet<MealType> MealTypes { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.AirlineId).HasName("PK__Airlines__A016BF8090CACD74");

            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Airplane>(entity =>
        {
            entity.HasKey(e => e.AirplaneId).HasName("PK__Airplane__CECD2849B1B94DCA");

            entity.Property(e => e.AirplaneId).HasColumnName("airplane_id");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
            entity.Property(e => e.TotalSeats).HasColumnName("total_seats");
        });

        modelBuilder.Entity<CheckIn>(entity =>
        {
            entity.HasKey(e => e.CheckinId).HasName("PK__CheckIns__234E2115E4228649");

            entity.Property(e => e.CheckinId).HasColumnName("checkin_id");
            entity.Property(e => e.CheckinTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("checkin_time");
            entity.Property(e => e.ReservationId).HasColumnName("reservation_id");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");

            entity.HasOne(d => d.Reservation).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.ReservationId)
                .HasConstraintName("FK_CheckIns_Reservations");

            entity.HasOne(d => d.Seat).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.SeatId)
                .HasConstraintName("FK_CheckIns_Seats");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__C52E0BA830E8EBD2");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(e => e.User)
            .WithOne(u => u.Employee)
               .HasForeignKey<Employee>(e => e.UserId);


            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Employees_Position");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__Flights__E3705765AA48850A");

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.AirplaneId).HasColumnName("airplane_id");
            entity.Property(e => e.ArrivalLocation)
                .HasMaxLength(100)
                .HasColumnName("arrival_location");
            entity.Property(e => e.ArrivalTime)
                .HasColumnType("datetime")
                .HasColumnName("arrival_time");
            entity.Property(e => e.DepartureLocation)
                .HasMaxLength(100)
                .HasColumnName("departure_location");
            entity.Property(e => e.DepartureTime)
                .HasColumnType("datetime")
                .HasColumnName("departure_time");

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("FK_Flights_Airlines");
        });

        modelBuilder.Entity<FlightReview>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__FlightRe__60883D90E9077F41");

            entity.Property(e => e.ReviewId).HasColumnName("review_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .HasColumnName("comment");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.SubmittedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("submitted_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Flight).WithMany(p => p.FlightReviews)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_Reviews_Flights");

            entity.HasOne(d => d.User).WithMany(p => p.FlightReviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reviews_Users");
        });

        modelBuilder.Entity<Luggage>(entity =>
        {
            entity.HasKey(e => e.LuggageId).HasName("PK__Luggages__00F3B1704651ABD8");

            entity.Property(e => e.LuggageId).HasColumnName("luggage_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Luggage)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Luggages_Users");
        });

        modelBuilder.Entity<LuggageReport>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__LuggageR__779B7C58AE1E15BE");

            entity.Property(e => e.ReportId).HasColumnName("report_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.LuggageId).HasColumnName("luggage_id");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("notes");
            entity.Property(e => e.ReportTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("report_time");
            entity.Property(e => e.ReportType)
                .HasMaxLength(50)
                .HasColumnName("report_type");

            entity.HasOne(d => d.Employee).WithMany(p => p.LuggageReports)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Reports_Employees");

            entity.HasOne(d => d.Luggage).WithMany(p => p.LuggageReports)
                .HasForeignKey(d => d.LuggageId)
                .HasConstraintName("FK_Reports_Luggages");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__E059842F621D3789");

            entity.Property(e => e.NotificationId).HasColumnName("notification_id");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.SentAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("sent_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Notifications_Users");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__ED1FC9EAF4FBAC60");

            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .HasColumnName("payment_method");
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(100)
                .HasColumnName("transaction_reference");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Payments_Users");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK__Position__99A0E7A4DB79BFD1");

            entity.Property(e => e.PositionId).HasColumnName("position_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__31384C299B9BC2CB");

            entity.Property(e => e.ReservationId).HasColumnName("reservation_id");
            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.AirportId).HasColumnName("airport_id");

            entity.Property(e => e.ReservationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("reservation_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Flight).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK_Reservations_Flights");

            entity.HasOne(d => d.Payment).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.PaymentId)
                .HasConstraintName("FK_Reservations_Payments");

            entity.HasOne(d => d.User).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Reservations_Users");


            entity.HasOne(d => d.Airport)
                   .WithMany(a => a.Reservations)
                    .HasForeignKey(d => d.AirportId)
                    .HasConstraintName("FK_Reservations_Airports");

            entity.HasOne(d => d.Seat)
            .WithMany(p => p.Reservations)
            .HasForeignKey(d => d.SeatId)
            .HasConstraintName("FK_Reservations_Seats");

            entity.HasOne(d => d.MealType)
            .WithMany()
            .HasForeignKey(d => d.MealTypeId)
            .HasConstraintName("FK_Reservations_MealTypes");

        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A4E9A155F");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.SeatId).HasName("PK__Seats__906DED9C5162B2D2");

            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.AirplaneId).HasColumnName("airplane_id");
            entity.Property(e => e.SeatClassId).HasColumnName("seat_class_id");
            entity.Property(e => e.SeatNumber)
                .HasMaxLength(10)
                .HasColumnName("seat_number");

            entity.HasOne(d => d.Airplane).WithMany(p => p.Seats)
                .HasForeignKey(d => d.AirplaneId)
                .HasConstraintName("FK_Seats_Airplanes");

            entity.HasOne(d => d.SeatClass).WithMany(p => p.Seats)
                .HasForeignKey(d => d.SeatClassId)
                .HasConstraintName("FK_Seats_SeatClasses");
        });

        modelBuilder.Entity<SeatClass>(entity =>
        {
            entity.HasKey(e => e.SeatClassId).HasName("PK__SeatClas__DC348A0F7232C36B");

            entity.Property(e => e.SeatClassId).HasColumnName("seat_class_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F977AC3CB");

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E6164AA0B9A02").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");

            entity.HasOne(u => u.Employee)
                  .WithOne(e => e.User)
                  .HasForeignKey<Employee>(e => e.UserId)
                  .HasConstraintName("FK_Employees_Users");
        });


        modelBuilder.Entity<UserRole>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleId);

        modelBuilder.Entity<Airline>()
            .HasOne(a => a.Airport)
            .WithMany(ap => ap.Airlines)
            .HasForeignKey(a => a.AirportId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Luggage>()
            .HasOne(l => l.Airport)
            .WithMany()
            .HasForeignKey(l => l.AirportId)
            .OnDelete(DeleteBehavior.SetNull);


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
