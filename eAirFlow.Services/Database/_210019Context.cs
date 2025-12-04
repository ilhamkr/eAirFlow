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
        

        modelBuilder.Entity<CheckIn>(entity =>
        {
            entity.Property(e => e.CheckinTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Reservation).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.ReservationId);

            entity.HasOne(d => d.Seat).WithMany(p => p.CheckIns)
                .HasForeignKey(d => d.SeatId);
        });

        modelBuilder.Entity<Employee>(entity =>
        {

            entity.HasOne(e => e.User)
            .WithOne(u => u.Employee)
               .HasForeignKey<Employee>(e => e.UserId);


            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId);
        });

        modelBuilder.Entity<Flight>(entity =>
        {

            entity.HasOne(d => d.Airline).WithMany(p => p.Flights)
                .HasForeignKey(d => d.AirlineId);
        });

        modelBuilder.Entity<FlightReview>(entity =>
        {
            entity.HasKey(e => e.ReviewId);


            entity.HasOne(d => d.Flight).WithMany(p => p.FlightReviews)
                .HasForeignKey(d => d.FlightId);

            entity.HasOne(d => d.User).WithMany(p => p.FlightReviews)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Luggage>(entity =>
        {

            entity.HasOne(d => d.User).WithMany(p => p.Luggage)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<LuggageReport>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.HasOne(d => d.Employee).WithMany(p => p.LuggageReports)
                .HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.Luggage).WithMany(p => p.LuggageReports)
                .HasForeignKey(d => d.LuggageId);
        });

        modelBuilder.Entity<Notification>(entity =>
        {

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId);
        });


        modelBuilder.Entity<Reservation>(entity =>
        {

            entity.HasOne(d => d.Flight).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.FlightId);

            entity.HasOne(d => d.Payment).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.PaymentId);

            entity.HasOne(d => d.User).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.UserId);


            entity.HasOne(d => d.Airport)
                   .WithMany(a => a.Reservations)
                    .HasForeignKey(d => d.AirportId);

            entity.HasOne(d => d.Seat)
            .WithMany(p => p.Reservations)
            .HasForeignKey(d => d.SeatId);


            entity.HasOne(d => d.MealType)
            .WithMany()
            .HasForeignKey(d => d.MealTypeId);

        });


        modelBuilder.Entity<Seat>(entity =>
        {
            

            entity.HasOne(d => d.Airplane).WithMany(p => p.Seats)
                .HasForeignKey(d => d.AirplaneId);

            entity.HasOne(d => d.SeatClass).WithMany(p => p.Seats)
                .HasForeignKey(d => d.SeatClassId);
             
        });


        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(u => u.Employee)
                  .WithOne(e => e.User)
                  .HasForeignKey<Employee>(e => e.UserId);
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
