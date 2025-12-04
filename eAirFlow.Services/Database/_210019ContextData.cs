using eAirFlow.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Database
{
    public partial class _210019Context
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 1, Name = "User" },
                new Role { RoleId = 2, Name = "Employee" },
                new Role { RoleId = 3, Name = "Admin" });

            modelBuilder.Entity<Position>().HasData(new Position
            { PositionId = 1, Name = "Technician", Description = "Handles maintenance and technical operations" },
            new Position { PositionId = 2, Name = "Gate Agent", Description = "Manages boarding and gate activities" },
            new Position { PositionId = 3, Name = "Security Officer", Description = "Ensures passenger and airport security" });

            modelBuilder.Entity<Airport>().HasData(
                new Airport { AirportId = 1, Name = "Sarajevo International Airport", City = "Sarajevo", Country = "Bosnia and Herzegovina" },
                new Airport { AirportId = 2, Name = "Mostar International Airport", City = "Mostar", Country = "Bosnia and Herzegovina" });

            modelBuilder.Entity<Airline>().HasData(
                new Airline { AirlineId = 1, Name = "Turkish Airlines", Country = "Turkey", AirportId = 1 },
                new Airline { AirlineId = 2, Name = "Ryanair", Country = "Republic of Ireland", AirportId = 1 },
                new Airline { AirlineId = 3, Name = "Lufthansa", Country = "Germany", AirportId = 2 });

            modelBuilder.Entity<Airplane>().HasData(
                new Airplane { AirplaneId = 1, Model = "Boeing 737", TotalSeats = 180, AirlineId = 1 },
                new Airplane { AirplaneId = 2, Model = "Airbus A320", TotalSeats = 160, AirlineId = 2 },
                new Airplane { AirplaneId = 3, Model = "Boeing 777", TotalSeats = 300, AirlineId = 3 });

            modelBuilder.Entity<SeatClass>().HasData(
                new SeatClass { SeatClassId = 1, Name = "Economy" },
                new SeatClass { SeatClassId = 2, Name = "Business" },
                new SeatClass { SeatClassId = 3, Name = "First" });

            modelBuilder.Entity<MealType>().HasData(
                new MealType { MealTypeId = 1, Name = "Standard Meal", Price = 12 },
                new MealType { MealTypeId = 2, Name = "Vegetarian", Price = 14 },
                new MealType { MealTypeId = 3, Name = "Vegan", Price = 15 });

            List<string> Salt = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Salt.Add(HashHelper.GenerateSalt());
            }

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "User",
                    Surname = "User",
                    Email = "user@example.com",
                    PasswordSalt = Salt[0],
                    PasswordHash = HashHelper.GenerateHash(Salt[0], "test"),
                    PhoneNumber = "555-555",
                    CreatedAt = DateTime.UtcNow,
                    ProfileImageUrl = null
                },
                new User
                {
                    UserId = 2,
                    Name = "Employee",
                    Surname = "Employee",
                    Email = "employee@example.com",
                    PasswordSalt = Salt[0],
                    PasswordHash = HashHelper.GenerateHash(Salt[0], "test"),
                    PhoneNumber = "555-555",
                    CreatedAt = DateTime.UtcNow,
                    ProfileImageUrl = null
                },
                new User
                {
                    UserId = 3,
                    Name = "Admin",
                    Surname = "Admin",
                    Email = "admin@example.com",
                    PasswordSalt = Salt[0],
                    PasswordHash = HashHelper.GenerateHash(Salt[0], "test"),
                    PhoneNumber = "555-555",
                    CreatedAt = DateTime.UtcNow,
                    ProfileImageUrl = null
                });

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    UserId = 1,
                    RoleId = 1,
                },
                new UserRole
                {
                    UserId = 2,
                    RoleId = 2,
                },
                new UserRole
                {
                    UserId = 3,
                    RoleId = 3,
                });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "employee",
                    Surname = "employee",
                    Email = "employee@example.com",
                    PhoneNumber = "555-555",
                    HireDate = DateTime.UtcNow,
                    PositionId = 1,
                    UserId = 2,
                    AirportId = 1,
                });

            List<Seat>seats = new List<Seat>();
            int seatId = 1;
            string[] seatLetters = { "A", "B", "C", "D", "E", "F" };

            for (int airplaneId = 1; airplaneId <= 3; airplaneId++)
            {
                for (int row = 1; row <= 30; row++)
                {
                    foreach (string letter in seatLetters)
                    {
                        string seatNumber = $"{row}{letter}";

                        seats.Add(new Seat { SeatId = seatId, SeatNumber = seatNumber, SeatClassId = 1, AirplaneId = airplaneId});

                        seatId++;
                    }
                }
            }

            modelBuilder.Entity<Seat>().HasData(seats);

            List<Flight> flights = new List<Flight>();
            int flightId = 1;
            DateTime start = DateTime.UtcNow.Date;

            string[] sarajevoDest = { "Istanbul", "Berlin", "Roma", "Paris" };
            string[] mostarDest = { "Munich", "Frankfurt" };

            for (int day = 0; day < 20; day++)
            {
                DateTime date = start.AddDays(day);

                for (int i = 0; i < 4; i++)
                {
                    string dest = sarajevoDest[i % sarajevoDest.Length];
                    DateTime dep = date.AddHours(8 + i);
                    DateTime arr = date.AddHours(10 + i);
                    int price = 150 + i * 5;

                    flights.Add(new Flight { FlightId = flightId, DepartureLocation = "Sarajevo", ArrivalLocation = dest, DepartureTime = dep, ArrivalTime = arr, AirlineId = 1, AirplaneId = 1, StateMachine = "scheduled", Price = price });
                    flightId++;
                }

                for (int i = 0; i < 2; i++)
                {
                    string dest = mostarDest[i % mostarDest.Length];
                    DateTime dep = date.AddHours(12 + i);
                    DateTime arr = date.AddHours(14 + i);
                    int price = 130 + i * 10;

                    flights.Add(new Flight { FlightId = flightId, DepartureLocation = "Mostar", ArrivalLocation = dest, DepartureTime = dep, ArrivalTime = arr, AirlineId = 1, AirplaneId = 1, StateMachine = "scheduled", Price = price });
                    flightId++;
                }
            }
            modelBuilder.Entity<Flight>().HasData(flights);

        }
    }
}
