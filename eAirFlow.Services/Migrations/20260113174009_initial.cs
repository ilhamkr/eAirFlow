using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.AirportId);
                });

            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.MealTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "SeatClasses",
                columns: table => new
                {
                    SeatClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatClasses", x => x.SeatClassId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    AirlineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.AirlineId);
                    table.ForeignKey(
                        name: "FK_Airlines_Airports_AirportId",
                        column: x => x.AirportId,
                        principalTable: "Airports",
                        principalColumn: "AirportId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfirmations",
                columns: table => new
                {
                    EmailConfirmationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfirmations", x => x.EmailConfirmationId);
                    table.ForeignKey(
                        name: "FK_EmailConfirmations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    AirportId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Airports_AirportId",
                        column: x => x.AirportId,
                        principalTable: "Airports",
                        principalColumn: "AirportId");
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId");
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    AirplaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSeats = table.Column<int>(type: "int", nullable: true),
                    AirlineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.AirplaneId);
                    table.ForeignKey(
                        name: "FK_Airplanes_Airlines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airlines",
                        principalColumn: "AirlineId");
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DepartureTimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArrivalTimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineId = table.Column<int>(type: "int", nullable: true),
                    AirplaneId = table.Column<int>(type: "int", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flights_Airlines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airlines",
                        principalColumn: "AirlineId");
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirplaneId = table.Column<int>(type: "int", nullable: true),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seats_Airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplanes",
                        principalColumn: "AirplaneId");
                    table.ForeignKey(
                        name: "FK_Seats_SeatClasses_SeatClassId",
                        column: x => x.SeatClassId,
                        principalTable: "SeatClasses",
                        principalColumn: "SeatClassId");
                });

            migrationBuilder.CreateTable(
                name: "FlightReviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightReviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_FlightReviews_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId");
                    table.ForeignKey(
                        name: "FK_FlightReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Luggages",
                columns: table => new
                {
                    LuggageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirportId = table.Column<int>(type: "int", nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luggages", x => x.LuggageId);
                    table.ForeignKey(
                        name: "FK_Luggages_Airports_AirportId",
                        column: x => x.AirportId,
                        principalTable: "Airports",
                        principalColumn: "AirportId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Luggages_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId");
                    table.ForeignKey(
                        name: "FK_Luggages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    AirportId = table.Column<int>(type: "int", nullable: true),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AirplaneId = table.Column<int>(type: "int", nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    MealTypeId = table.Column<int>(type: "int", nullable: true),
                    QrCodeBase64 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaggageInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplanes",
                        principalColumn: "AirplaneId");
                    table.ForeignKey(
                        name: "FK_Reservations_Airports_AirportId",
                        column: x => x.AirportId,
                        principalTable: "Airports",
                        principalColumn: "AirportId");
                    table.ForeignKey(
                        name: "FK_Reservations_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId");
                    table.ForeignKey(
                        name: "FK_Reservations_MealTypes_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealTypes",
                        principalColumn: "MealTypeId");
                    table.ForeignKey(
                        name: "FK_Reservations_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId");
                    table.ForeignKey(
                        name: "FK_Reservations_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId");
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "LuggageReports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuggageId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuggageReports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_LuggageReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_LuggageReports_Luggages_LuggageId",
                        column: x => x.LuggageId,
                        principalTable: "Luggages",
                        principalColumn: "LuggageId");
                });

            migrationBuilder.CreateTable(
                name: "CheckIns",
                columns: table => new
                {
                    CheckinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true),
                    CheckinTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckIns", x => x.CheckinId);
                    table.ForeignKey(
                        name: "FK_CheckIns_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId");
                    table.ForeignKey(
                        name: "FK_CheckIns_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId");
                    table.ForeignKey(
                        name: "FK_CheckIns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "AirportId", "City", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Sarajevo", "Bosnia and Herzegovina", "Sarajevo International Airport" },
                    { 2, "Mostar", "Bosnia and Herzegovina", "Mostar International Airport" }
                });

            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "MealTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Standard Meal", 12m },
                    { 2, "Vegetarian", 14m },
                    { 3, "Vegan", 15m }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Handles maintenance and technical operations", "Technician" },
                    { 2, "Manages boarding and gate activities", "Gate Agent" },
                    { 3, "Ensures passenger and airport security", "Security Officer" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Employee" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SeatClasses",
                columns: new[] { "SeatClassId", "Name" },
                values: new object[,]
                {
                    { 1, "Economy" },
                    { 2, "Business" },
                    { 3, "First" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfileImageUrl", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 13, 17, 40, 8, 932, DateTimeKind.Utc).AddTicks(3593), "user@example.com", "User", "Wwjipm1zzzD/wFESkFS7XjPXobR2aoD1F/WmB0cwTXg=", "WBK8UIHDgUifTke3sSEyjw==", "555-555", null, "User" },
                    { 2, new DateTime(2026, 1, 13, 17, 40, 8, 932, DateTimeKind.Utc).AddTicks(3618), "employee@example.com", "Employee", "Wwjipm1zzzD/wFESkFS7XjPXobR2aoD1F/WmB0cwTXg=", "WBK8UIHDgUifTke3sSEyjw==", "555-555", null, "Employee" },
                    { 3, new DateTime(2026, 1, 13, 17, 40, 8, 932, DateTimeKind.Utc).AddTicks(3633), "admin@example.com", "Admin", "Wwjipm1zzzD/wFESkFS7XjPXobR2aoD1F/WmB0cwTXg=", "WBK8UIHDgUifTke3sSEyjw==", "555-555", null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "AirlineId", "AirportId", "Country", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Turkey", "Turkish Airlines" },
                    { 2, 1, "Republic of Ireland", "Ryanair" },
                    { 3, 2, "Germany", "Lufthansa" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AirportId", "Email", "HireDate", "Name", "PhoneNumber", "PositionId", "Surname", "UserId" },
                values: new object[] { 1, 1, "employee@example.com", new DateTime(2026, 1, 13, 17, 40, 8, 932, DateTimeKind.Utc).AddTicks(3693), "employee", "555-555", 1, "employee", 2 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "AirlineId", "Model", "TotalSeats" },
                values: new object[,]
                {
                    { 1, 1, "Boeing 737", 180 },
                    { 2, 2, "Airbus A320", 160 },
                    { 3, 3, "Boeing 777", 300 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price", "StateMachine" },
                values: new object[,]
                {
                    { 1, 1, 1, "Istanbul", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 2, 1, 1, "Berlin", new DateTime(2026, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 3, 1, 1, "Rome", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 4, 1, 1, "Paris", new DateTime(2026, 1, 13, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 5, 1, 1, "New York", new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 6, 2, 2, "Berlin", new DateTime(2026, 1, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 7, 2, 2, "Rome", new DateTime(2026, 1, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 8, 2, 2, "Paris", new DateTime(2026, 1, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 9, 3, 3, "Munich", new DateTime(2026, 1, 13, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 10, 3, 3, "Frankfurt", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 11, 1, 1, "Istanbul", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 12, 1, 1, "Berlin", new DateTime(2026, 1, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 13, 1, 1, "Rome", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 14, 1, 1, "Paris", new DateTime(2026, 1, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 15, 1, 1, "New York", new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 16, 2, 2, "Berlin", new DateTime(2026, 1, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 17, 2, 2, "Rome", new DateTime(2026, 1, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 18, 2, 2, "Paris", new DateTime(2026, 1, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 19, 3, 3, "Munich", new DateTime(2026, 1, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 20, 3, 3, "Frankfurt", new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 21, 1, 1, "Istanbul", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 22, 1, 1, "Berlin", new DateTime(2026, 1, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 23, 1, 1, "Rome", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 24, 1, 1, "Paris", new DateTime(2026, 1, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 25, 1, 1, "New York", new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 26, 2, 2, "Berlin", new DateTime(2026, 1, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 27, 2, 2, "Rome", new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 28, 2, 2, "Paris", new DateTime(2026, 1, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 29, 3, 3, "Munich", new DateTime(2026, 1, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 30, 3, 3, "Frankfurt", new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 31, 1, 1, "Istanbul", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 32, 1, 1, "Berlin", new DateTime(2026, 1, 16, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 33, 1, 1, "Rome", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 34, 1, 1, "Paris", new DateTime(2026, 1, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 35, 1, 1, "New York", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 36, 2, 2, "Berlin", new DateTime(2026, 1, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 37, 2, 2, "Rome", new DateTime(2026, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 38, 2, 2, "Paris", new DateTime(2026, 1, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 39, 3, 3, "Munich", new DateTime(2026, 1, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 40, 3, 3, "Frankfurt", new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 41, 1, 1, "Istanbul", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 42, 1, 1, "Berlin", new DateTime(2026, 1, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 43, 1, 1, "Rome", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 44, 1, 1, "Paris", new DateTime(2026, 1, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 45, 1, 1, "New York", new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 46, 2, 2, "Berlin", new DateTime(2026, 1, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 47, 2, 2, "Rome", new DateTime(2026, 1, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 48, 2, 2, "Paris", new DateTime(2026, 1, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 49, 3, 3, "Munich", new DateTime(2026, 1, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 50, 3, 3, "Frankfurt", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 51, 1, 1, "Istanbul", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 52, 1, 1, "Berlin", new DateTime(2026, 1, 18, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 53, 1, 1, "Rome", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 54, 1, 1, "Paris", new DateTime(2026, 1, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 55, 1, 1, "New York", new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 56, 2, 2, "Berlin", new DateTime(2026, 1, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 57, 2, 2, "Rome", new DateTime(2026, 1, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 58, 2, 2, "Paris", new DateTime(2026, 1, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 59, 3, 3, "Munich", new DateTime(2026, 1, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 60, 3, 3, "Frankfurt", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 61, 1, 1, "Istanbul", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 62, 1, 1, "Berlin", new DateTime(2026, 1, 19, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 63, 1, 1, "Rome", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 64, 1, 1, "Paris", new DateTime(2026, 1, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 65, 1, 1, "New York", new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 66, 2, 2, "Berlin", new DateTime(2026, 1, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 67, 2, 2, "Rome", new DateTime(2026, 1, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 68, 2, 2, "Paris", new DateTime(2026, 1, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 69, 3, 3, "Munich", new DateTime(2026, 1, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 70, 3, 3, "Frankfurt", new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 71, 1, 1, "Istanbul", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 72, 1, 1, "Berlin", new DateTime(2026, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 73, 1, 1, "Rome", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 74, 1, 1, "Paris", new DateTime(2026, 1, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 75, 1, 1, "New York", new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 76, 2, 2, "Berlin", new DateTime(2026, 1, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 77, 2, 2, "Rome", new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 78, 2, 2, "Paris", new DateTime(2026, 1, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 79, 3, 3, "Munich", new DateTime(2026, 1, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 80, 3, 3, "Frankfurt", new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 81, 1, 1, "Istanbul", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 82, 1, 1, "Berlin", new DateTime(2026, 1, 21, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 83, 1, 1, "Rome", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 84, 1, 1, "Paris", new DateTime(2026, 1, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 85, 1, 1, "New York", new DateTime(2026, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 86, 2, 2, "Berlin", new DateTime(2026, 1, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 87, 2, 2, "Rome", new DateTime(2026, 1, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 88, 2, 2, "Paris", new DateTime(2026, 1, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 89, 3, 3, "Munich", new DateTime(2026, 1, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 90, 3, 3, "Frankfurt", new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 91, 1, 1, "Istanbul", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 22, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 92, 1, 1, "Berlin", new DateTime(2026, 1, 22, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 93, 1, 1, "Rome", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 94, 1, 1, "Paris", new DateTime(2026, 1, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 95, 1, 1, "New York", new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 96, 2, 2, "Berlin", new DateTime(2026, 1, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 97, 2, 2, "Rome", new DateTime(2026, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 98, 2, 2, "Paris", new DateTime(2026, 1, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 99, 3, 3, "Munich", new DateTime(2026, 1, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 100, 3, 3, "Frankfurt", new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 101, 1, 1, "Istanbul", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 23, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 102, 1, 1, "Berlin", new DateTime(2026, 1, 23, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 103, 1, 1, "Rome", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 104, 1, 1, "Paris", new DateTime(2026, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 105, 1, 1, "New York", new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 106, 2, 2, "Berlin", new DateTime(2026, 1, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 107, 2, 2, "Rome", new DateTime(2026, 1, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 108, 2, 2, "Paris", new DateTime(2026, 1, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 109, 3, 3, "Munich", new DateTime(2026, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 110, 3, 3, "Frankfurt", new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 111, 1, 1, "Istanbul", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 24, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 112, 1, 1, "Berlin", new DateTime(2026, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 113, 1, 1, "Rome", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 114, 1, 1, "Paris", new DateTime(2026, 1, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 115, 1, 1, "New York", new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 116, 2, 2, "Berlin", new DateTime(2026, 1, 24, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 117, 2, 2, "Rome", new DateTime(2026, 1, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 118, 2, 2, "Paris", new DateTime(2026, 1, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 119, 3, 3, "Munich", new DateTime(2026, 1, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 120, 3, 3, "Frankfurt", new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 121, 1, 1, "Istanbul", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 25, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 122, 1, 1, "Berlin", new DateTime(2026, 1, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 123, 1, 1, "Rome", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 124, 1, 1, "Paris", new DateTime(2026, 1, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 125, 1, 1, "New York", new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 126, 2, 2, "Berlin", new DateTime(2026, 1, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 127, 2, 2, "Rome", new DateTime(2026, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 128, 2, 2, "Paris", new DateTime(2026, 1, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 129, 3, 3, "Munich", new DateTime(2026, 1, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 130, 3, 3, "Frankfurt", new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 131, 1, 1, "Istanbul", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 26, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 132, 1, 1, "Berlin", new DateTime(2026, 1, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 133, 1, 1, "Rome", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 134, 1, 1, "Paris", new DateTime(2026, 1, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 135, 1, 1, "New York", new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 136, 2, 2, "Berlin", new DateTime(2026, 1, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 137, 2, 2, "Rome", new DateTime(2026, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 138, 2, 2, "Paris", new DateTime(2026, 1, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 139, 3, 3, "Munich", new DateTime(2026, 1, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 140, 3, 3, "Frankfurt", new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 141, 1, 1, "Istanbul", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 142, 1, 1, "Berlin", new DateTime(2026, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 143, 1, 1, "Rome", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 144, 1, 1, "Paris", new DateTime(2026, 1, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 145, 1, 1, "New York", new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 146, 2, 2, "Berlin", new DateTime(2026, 1, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 147, 2, 2, "Rome", new DateTime(2026, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 148, 2, 2, "Paris", new DateTime(2026, 1, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 149, 3, 3, "Munich", new DateTime(2026, 1, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 150, 3, 3, "Frankfurt", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 151, 1, 1, "Istanbul", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 28, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 152, 1, 1, "Berlin", new DateTime(2026, 1, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 153, 1, 1, "Rome", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 154, 1, 1, "Paris", new DateTime(2026, 1, 28, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 155, 1, 1, "New York", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 156, 2, 2, "Berlin", new DateTime(2026, 1, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 157, 2, 2, "Rome", new DateTime(2026, 1, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 158, 2, 2, "Paris", new DateTime(2026, 1, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 159, 3, 3, "Munich", new DateTime(2026, 1, 28, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 160, 3, 3, "Frankfurt", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 161, 1, 1, "Istanbul", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 29, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 162, 1, 1, "Berlin", new DateTime(2026, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 163, 1, 1, "Rome", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 164, 1, 1, "Paris", new DateTime(2026, 1, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 165, 1, 1, "New York", new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 166, 2, 2, "Berlin", new DateTime(2026, 1, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 167, 2, 2, "Rome", new DateTime(2026, 1, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 168, 2, 2, "Paris", new DateTime(2026, 1, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 169, 3, 3, "Munich", new DateTime(2026, 1, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 170, 3, 3, "Frankfurt", new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 171, 1, 1, "Istanbul", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 172, 1, 1, "Berlin", new DateTime(2026, 1, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 173, 1, 1, "Rome", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 174, 1, 1, "Paris", new DateTime(2026, 1, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 175, 1, 1, "New York", new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 176, 2, 2, "Berlin", new DateTime(2026, 1, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 177, 2, 2, "Rome", new DateTime(2026, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 178, 2, 2, "Paris", new DateTime(2026, 1, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 179, 3, 3, "Munich", new DateTime(2026, 1, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 180, 3, 3, "Frankfurt", new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 181, 1, 1, "Istanbul", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 182, 1, 1, "Berlin", new DateTime(2026, 1, 31, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 183, 1, 1, "Rome", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 184, 1, 1, "Paris", new DateTime(2026, 1, 31, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 185, 1, 1, "New York", new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 186, 2, 2, "Berlin", new DateTime(2026, 1, 31, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 187, 2, 2, "Rome", new DateTime(2026, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 188, 2, 2, "Paris", new DateTime(2026, 1, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 189, 3, 3, "Munich", new DateTime(2026, 1, 31, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 190, 3, 3, "Frankfurt", new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 191, 1, 1, "Istanbul", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 2, 1, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 192, 1, 1, "Berlin", new DateTime(2026, 2, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 193, 1, 1, "Rome", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 194, 1, 1, "Paris", new DateTime(2026, 2, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 195, 1, 1, "New York", new DateTime(2026, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 196, 2, 2, "Berlin", new DateTime(2026, 2, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 197, 2, 2, "Rome", new DateTime(2026, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 198, 2, 2, "Paris", new DateTime(2026, 2, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 199, 3, 3, "Munich", new DateTime(2026, 2, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 200, 3, 3, "Frankfurt", new DateTime(2026, 2, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 2, 1, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "AirplaneId", "SeatClassId", "SeatNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, "1A" },
                    { 2, 1, 1, "1B" },
                    { 3, 1, 1, "1C" },
                    { 4, 1, 1, "1D" },
                    { 5, 1, 1, "1E" },
                    { 6, 1, 1, "1F" },
                    { 7, 1, 1, "2A" },
                    { 8, 1, 1, "2B" },
                    { 9, 1, 1, "2C" },
                    { 10, 1, 1, "2D" },
                    { 11, 1, 1, "2E" },
                    { 12, 1, 1, "2F" },
                    { 13, 1, 1, "3A" },
                    { 14, 1, 1, "3B" },
                    { 15, 1, 1, "3C" },
                    { 16, 1, 1, "3D" },
                    { 17, 1, 1, "3E" },
                    { 18, 1, 1, "3F" },
                    { 19, 1, 1, "4A" },
                    { 20, 1, 1, "4B" },
                    { 21, 1, 1, "4C" },
                    { 22, 1, 1, "4D" },
                    { 23, 1, 1, "4E" },
                    { 24, 1, 1, "4F" },
                    { 25, 1, 1, "5A" },
                    { 26, 1, 1, "5B" },
                    { 27, 1, 1, "5C" },
                    { 28, 1, 1, "5D" },
                    { 29, 1, 1, "5E" },
                    { 30, 1, 1, "5F" },
                    { 31, 1, 1, "6A" },
                    { 32, 1, 1, "6B" },
                    { 33, 1, 1, "6C" },
                    { 34, 1, 1, "6D" },
                    { 35, 1, 1, "6E" },
                    { 36, 1, 1, "6F" },
                    { 37, 1, 1, "7A" },
                    { 38, 1, 1, "7B" },
                    { 39, 1, 1, "7C" },
                    { 40, 1, 1, "7D" },
                    { 41, 1, 1, "7E" },
                    { 42, 1, 1, "7F" },
                    { 43, 1, 1, "8A" },
                    { 44, 1, 1, "8B" },
                    { 45, 1, 1, "8C" },
                    { 46, 1, 1, "8D" },
                    { 47, 1, 1, "8E" },
                    { 48, 1, 1, "8F" },
                    { 49, 1, 1, "9A" },
                    { 50, 1, 1, "9B" },
                    { 51, 1, 1, "9C" },
                    { 52, 1, 1, "9D" },
                    { 53, 1, 1, "9E" },
                    { 54, 1, 1, "9F" },
                    { 55, 1, 1, "10A" },
                    { 56, 1, 1, "10B" },
                    { 57, 1, 1, "10C" },
                    { 58, 1, 1, "10D" },
                    { 59, 1, 1, "10E" },
                    { 60, 1, 1, "10F" },
                    { 61, 1, 1, "11A" },
                    { 62, 1, 1, "11B" },
                    { 63, 1, 1, "11C" },
                    { 64, 1, 1, "11D" },
                    { 65, 1, 1, "11E" },
                    { 66, 1, 1, "11F" },
                    { 67, 1, 1, "12A" },
                    { 68, 1, 1, "12B" },
                    { 69, 1, 1, "12C" },
                    { 70, 1, 1, "12D" },
                    { 71, 1, 1, "12E" },
                    { 72, 1, 1, "12F" },
                    { 73, 1, 1, "13A" },
                    { 74, 1, 1, "13B" },
                    { 75, 1, 1, "13C" },
                    { 76, 1, 1, "13D" },
                    { 77, 1, 1, "13E" },
                    { 78, 1, 1, "13F" },
                    { 79, 1, 1, "14A" },
                    { 80, 1, 1, "14B" },
                    { 81, 1, 1, "14C" },
                    { 82, 1, 1, "14D" },
                    { 83, 1, 1, "14E" },
                    { 84, 1, 1, "14F" },
                    { 85, 1, 1, "15A" },
                    { 86, 1, 1, "15B" },
                    { 87, 1, 1, "15C" },
                    { 88, 1, 1, "15D" },
                    { 89, 1, 1, "15E" },
                    { 90, 1, 1, "15F" },
                    { 91, 1, 1, "16A" },
                    { 92, 1, 1, "16B" },
                    { 93, 1, 1, "16C" },
                    { 94, 1, 1, "16D" },
                    { 95, 1, 1, "16E" },
                    { 96, 1, 1, "16F" },
                    { 97, 1, 1, "17A" },
                    { 98, 1, 1, "17B" },
                    { 99, 1, 1, "17C" },
                    { 100, 1, 1, "17D" },
                    { 101, 1, 1, "17E" },
                    { 102, 1, 1, "17F" },
                    { 103, 1, 1, "18A" },
                    { 104, 1, 1, "18B" },
                    { 105, 1, 1, "18C" },
                    { 106, 1, 1, "18D" },
                    { 107, 1, 1, "18E" },
                    { 108, 1, 1, "18F" },
                    { 109, 1, 1, "19A" },
                    { 110, 1, 1, "19B" },
                    { 111, 1, 1, "19C" },
                    { 112, 1, 1, "19D" },
                    { 113, 1, 1, "19E" },
                    { 114, 1, 1, "19F" },
                    { 115, 1, 1, "20A" },
                    { 116, 1, 1, "20B" },
                    { 117, 1, 1, "20C" },
                    { 118, 1, 1, "20D" },
                    { 119, 1, 1, "20E" },
                    { 120, 1, 1, "20F" },
                    { 121, 1, 1, "21A" },
                    { 122, 1, 1, "21B" },
                    { 123, 1, 1, "21C" },
                    { 124, 1, 1, "21D" },
                    { 125, 1, 1, "21E" },
                    { 126, 1, 1, "21F" },
                    { 127, 1, 1, "22A" },
                    { 128, 1, 1, "22B" },
                    { 129, 1, 1, "22C" },
                    { 130, 1, 1, "22D" },
                    { 131, 1, 1, "22E" },
                    { 132, 1, 1, "22F" },
                    { 133, 1, 1, "23A" },
                    { 134, 1, 1, "23B" },
                    { 135, 1, 1, "23C" },
                    { 136, 1, 1, "23D" },
                    { 137, 1, 1, "23E" },
                    { 138, 1, 1, "23F" },
                    { 139, 1, 1, "24A" },
                    { 140, 1, 1, "24B" },
                    { 141, 1, 1, "24C" },
                    { 142, 1, 1, "24D" },
                    { 143, 1, 1, "24E" },
                    { 144, 1, 1, "24F" },
                    { 145, 1, 1, "25A" },
                    { 146, 1, 1, "25B" },
                    { 147, 1, 1, "25C" },
                    { 148, 1, 1, "25D" },
                    { 149, 1, 1, "25E" },
                    { 150, 1, 1, "25F" },
                    { 151, 1, 1, "26A" },
                    { 152, 1, 1, "26B" },
                    { 153, 1, 1, "26C" },
                    { 154, 1, 1, "26D" },
                    { 155, 1, 1, "26E" },
                    { 156, 1, 1, "26F" },
                    { 157, 1, 1, "27A" },
                    { 158, 1, 1, "27B" },
                    { 159, 1, 1, "27C" },
                    { 160, 1, 1, "27D" },
                    { 161, 1, 1, "27E" },
                    { 162, 1, 1, "27F" },
                    { 163, 1, 1, "28A" },
                    { 164, 1, 1, "28B" },
                    { 165, 1, 1, "28C" },
                    { 166, 1, 1, "28D" },
                    { 167, 1, 1, "28E" },
                    { 168, 1, 1, "28F" },
                    { 169, 1, 1, "29A" },
                    { 170, 1, 1, "29B" },
                    { 171, 1, 1, "29C" },
                    { 172, 1, 1, "29D" },
                    { 173, 1, 1, "29E" },
                    { 174, 1, 1, "29F" },
                    { 175, 1, 1, "30A" },
                    { 176, 1, 1, "30B" },
                    { 177, 1, 1, "30C" },
                    { 178, 1, 1, "30D" },
                    { 179, 1, 1, "30E" },
                    { 180, 1, 1, "30F" },
                    { 181, 2, 1, "1A" },
                    { 182, 2, 1, "1B" },
                    { 183, 2, 1, "1C" },
                    { 184, 2, 1, "1D" },
                    { 185, 2, 1, "1E" },
                    { 186, 2, 1, "1F" },
                    { 187, 2, 1, "2A" },
                    { 188, 2, 1, "2B" },
                    { 189, 2, 1, "2C" },
                    { 190, 2, 1, "2D" },
                    { 191, 2, 1, "2E" },
                    { 192, 2, 1, "2F" },
                    { 193, 2, 1, "3A" },
                    { 194, 2, 1, "3B" },
                    { 195, 2, 1, "3C" },
                    { 196, 2, 1, "3D" },
                    { 197, 2, 1, "3E" },
                    { 198, 2, 1, "3F" },
                    { 199, 2, 1, "4A" },
                    { 200, 2, 1, "4B" },
                    { 201, 2, 1, "4C" },
                    { 202, 2, 1, "4D" },
                    { 203, 2, 1, "4E" },
                    { 204, 2, 1, "4F" },
                    { 205, 2, 1, "5A" },
                    { 206, 2, 1, "5B" },
                    { 207, 2, 1, "5C" },
                    { 208, 2, 1, "5D" },
                    { 209, 2, 1, "5E" },
                    { 210, 2, 1, "5F" },
                    { 211, 2, 1, "6A" },
                    { 212, 2, 1, "6B" },
                    { 213, 2, 1, "6C" },
                    { 214, 2, 1, "6D" },
                    { 215, 2, 1, "6E" },
                    { 216, 2, 1, "6F" },
                    { 217, 2, 1, "7A" },
                    { 218, 2, 1, "7B" },
                    { 219, 2, 1, "7C" },
                    { 220, 2, 1, "7D" },
                    { 221, 2, 1, "7E" },
                    { 222, 2, 1, "7F" },
                    { 223, 2, 1, "8A" },
                    { 224, 2, 1, "8B" },
                    { 225, 2, 1, "8C" },
                    { 226, 2, 1, "8D" },
                    { 227, 2, 1, "8E" },
                    { 228, 2, 1, "8F" },
                    { 229, 2, 1, "9A" },
                    { 230, 2, 1, "9B" },
                    { 231, 2, 1, "9C" },
                    { 232, 2, 1, "9D" },
                    { 233, 2, 1, "9E" },
                    { 234, 2, 1, "9F" },
                    { 235, 2, 1, "10A" },
                    { 236, 2, 1, "10B" },
                    { 237, 2, 1, "10C" },
                    { 238, 2, 1, "10D" },
                    { 239, 2, 1, "10E" },
                    { 240, 2, 1, "10F" },
                    { 241, 2, 1, "11A" },
                    { 242, 2, 1, "11B" },
                    { 243, 2, 1, "11C" },
                    { 244, 2, 1, "11D" },
                    { 245, 2, 1, "11E" },
                    { 246, 2, 1, "11F" },
                    { 247, 2, 1, "12A" },
                    { 248, 2, 1, "12B" },
                    { 249, 2, 1, "12C" },
                    { 250, 2, 1, "12D" },
                    { 251, 2, 1, "12E" },
                    { 252, 2, 1, "12F" },
                    { 253, 2, 1, "13A" },
                    { 254, 2, 1, "13B" },
                    { 255, 2, 1, "13C" },
                    { 256, 2, 1, "13D" },
                    { 257, 2, 1, "13E" },
                    { 258, 2, 1, "13F" },
                    { 259, 2, 1, "14A" },
                    { 260, 2, 1, "14B" },
                    { 261, 2, 1, "14C" },
                    { 262, 2, 1, "14D" },
                    { 263, 2, 1, "14E" },
                    { 264, 2, 1, "14F" },
                    { 265, 2, 1, "15A" },
                    { 266, 2, 1, "15B" },
                    { 267, 2, 1, "15C" },
                    { 268, 2, 1, "15D" },
                    { 269, 2, 1, "15E" },
                    { 270, 2, 1, "15F" },
                    { 271, 2, 1, "16A" },
                    { 272, 2, 1, "16B" },
                    { 273, 2, 1, "16C" },
                    { 274, 2, 1, "16D" },
                    { 275, 2, 1, "16E" },
                    { 276, 2, 1, "16F" },
                    { 277, 2, 1, "17A" },
                    { 278, 2, 1, "17B" },
                    { 279, 2, 1, "17C" },
                    { 280, 2, 1, "17D" },
                    { 281, 2, 1, "17E" },
                    { 282, 2, 1, "17F" },
                    { 283, 2, 1, "18A" },
                    { 284, 2, 1, "18B" },
                    { 285, 2, 1, "18C" },
                    { 286, 2, 1, "18D" },
                    { 287, 2, 1, "18E" },
                    { 288, 2, 1, "18F" },
                    { 289, 2, 1, "19A" },
                    { 290, 2, 1, "19B" },
                    { 291, 2, 1, "19C" },
                    { 292, 2, 1, "19D" },
                    { 293, 2, 1, "19E" },
                    { 294, 2, 1, "19F" },
                    { 295, 2, 1, "20A" },
                    { 296, 2, 1, "20B" },
                    { 297, 2, 1, "20C" },
                    { 298, 2, 1, "20D" },
                    { 299, 2, 1, "20E" },
                    { 300, 2, 1, "20F" },
                    { 301, 2, 1, "21A" },
                    { 302, 2, 1, "21B" },
                    { 303, 2, 1, "21C" },
                    { 304, 2, 1, "21D" },
                    { 305, 2, 1, "21E" },
                    { 306, 2, 1, "21F" },
                    { 307, 2, 1, "22A" },
                    { 308, 2, 1, "22B" },
                    { 309, 2, 1, "22C" },
                    { 310, 2, 1, "22D" },
                    { 311, 2, 1, "22E" },
                    { 312, 2, 1, "22F" },
                    { 313, 2, 1, "23A" },
                    { 314, 2, 1, "23B" },
                    { 315, 2, 1, "23C" },
                    { 316, 2, 1, "23D" },
                    { 317, 2, 1, "23E" },
                    { 318, 2, 1, "23F" },
                    { 319, 2, 1, "24A" },
                    { 320, 2, 1, "24B" },
                    { 321, 2, 1, "24C" },
                    { 322, 2, 1, "24D" },
                    { 323, 2, 1, "24E" },
                    { 324, 2, 1, "24F" },
                    { 325, 2, 1, "25A" },
                    { 326, 2, 1, "25B" },
                    { 327, 2, 1, "25C" },
                    { 328, 2, 1, "25D" },
                    { 329, 2, 1, "25E" },
                    { 330, 2, 1, "25F" },
                    { 331, 2, 1, "26A" },
                    { 332, 2, 1, "26B" },
                    { 333, 2, 1, "26C" },
                    { 334, 2, 1, "26D" },
                    { 335, 2, 1, "26E" },
                    { 336, 2, 1, "26F" },
                    { 337, 2, 1, "27A" },
                    { 338, 2, 1, "27B" },
                    { 339, 2, 1, "27C" },
                    { 340, 2, 1, "27D" },
                    { 341, 2, 1, "27E" },
                    { 342, 2, 1, "27F" },
                    { 343, 2, 1, "28A" },
                    { 344, 2, 1, "28B" },
                    { 345, 2, 1, "28C" },
                    { 346, 2, 1, "28D" },
                    { 347, 2, 1, "28E" },
                    { 348, 2, 1, "28F" },
                    { 349, 2, 1, "29A" },
                    { 350, 2, 1, "29B" },
                    { 351, 2, 1, "29C" },
                    { 352, 2, 1, "29D" },
                    { 353, 2, 1, "29E" },
                    { 354, 2, 1, "29F" },
                    { 355, 2, 1, "30A" },
                    { 356, 2, 1, "30B" },
                    { 357, 2, 1, "30C" },
                    { 358, 2, 1, "30D" },
                    { 359, 2, 1, "30E" },
                    { 360, 2, 1, "30F" },
                    { 361, 3, 1, "1A" },
                    { 362, 3, 1, "1B" },
                    { 363, 3, 1, "1C" },
                    { 364, 3, 1, "1D" },
                    { 365, 3, 1, "1E" },
                    { 366, 3, 1, "1F" },
                    { 367, 3, 1, "2A" },
                    { 368, 3, 1, "2B" },
                    { 369, 3, 1, "2C" },
                    { 370, 3, 1, "2D" },
                    { 371, 3, 1, "2E" },
                    { 372, 3, 1, "2F" },
                    { 373, 3, 1, "3A" },
                    { 374, 3, 1, "3B" },
                    { 375, 3, 1, "3C" },
                    { 376, 3, 1, "3D" },
                    { 377, 3, 1, "3E" },
                    { 378, 3, 1, "3F" },
                    { 379, 3, 1, "4A" },
                    { 380, 3, 1, "4B" },
                    { 381, 3, 1, "4C" },
                    { 382, 3, 1, "4D" },
                    { 383, 3, 1, "4E" },
                    { 384, 3, 1, "4F" },
                    { 385, 3, 1, "5A" },
                    { 386, 3, 1, "5B" },
                    { 387, 3, 1, "5C" },
                    { 388, 3, 1, "5D" },
                    { 389, 3, 1, "5E" },
                    { 390, 3, 1, "5F" },
                    { 391, 3, 1, "6A" },
                    { 392, 3, 1, "6B" },
                    { 393, 3, 1, "6C" },
                    { 394, 3, 1, "6D" },
                    { 395, 3, 1, "6E" },
                    { 396, 3, 1, "6F" },
                    { 397, 3, 1, "7A" },
                    { 398, 3, 1, "7B" },
                    { 399, 3, 1, "7C" },
                    { 400, 3, 1, "7D" },
                    { 401, 3, 1, "7E" },
                    { 402, 3, 1, "7F" },
                    { 403, 3, 1, "8A" },
                    { 404, 3, 1, "8B" },
                    { 405, 3, 1, "8C" },
                    { 406, 3, 1, "8D" },
                    { 407, 3, 1, "8E" },
                    { 408, 3, 1, "8F" },
                    { 409, 3, 1, "9A" },
                    { 410, 3, 1, "9B" },
                    { 411, 3, 1, "9C" },
                    { 412, 3, 1, "9D" },
                    { 413, 3, 1, "9E" },
                    { 414, 3, 1, "9F" },
                    { 415, 3, 1, "10A" },
                    { 416, 3, 1, "10B" },
                    { 417, 3, 1, "10C" },
                    { 418, 3, 1, "10D" },
                    { 419, 3, 1, "10E" },
                    { 420, 3, 1, "10F" },
                    { 421, 3, 1, "11A" },
                    { 422, 3, 1, "11B" },
                    { 423, 3, 1, "11C" },
                    { 424, 3, 1, "11D" },
                    { 425, 3, 1, "11E" },
                    { 426, 3, 1, "11F" },
                    { 427, 3, 1, "12A" },
                    { 428, 3, 1, "12B" },
                    { 429, 3, 1, "12C" },
                    { 430, 3, 1, "12D" },
                    { 431, 3, 1, "12E" },
                    { 432, 3, 1, "12F" },
                    { 433, 3, 1, "13A" },
                    { 434, 3, 1, "13B" },
                    { 435, 3, 1, "13C" },
                    { 436, 3, 1, "13D" },
                    { 437, 3, 1, "13E" },
                    { 438, 3, 1, "13F" },
                    { 439, 3, 1, "14A" },
                    { 440, 3, 1, "14B" },
                    { 441, 3, 1, "14C" },
                    { 442, 3, 1, "14D" },
                    { 443, 3, 1, "14E" },
                    { 444, 3, 1, "14F" },
                    { 445, 3, 1, "15A" },
                    { 446, 3, 1, "15B" },
                    { 447, 3, 1, "15C" },
                    { 448, 3, 1, "15D" },
                    { 449, 3, 1, "15E" },
                    { 450, 3, 1, "15F" },
                    { 451, 3, 1, "16A" },
                    { 452, 3, 1, "16B" },
                    { 453, 3, 1, "16C" },
                    { 454, 3, 1, "16D" },
                    { 455, 3, 1, "16E" },
                    { 456, 3, 1, "16F" },
                    { 457, 3, 1, "17A" },
                    { 458, 3, 1, "17B" },
                    { 459, 3, 1, "17C" },
                    { 460, 3, 1, "17D" },
                    { 461, 3, 1, "17E" },
                    { 462, 3, 1, "17F" },
                    { 463, 3, 1, "18A" },
                    { 464, 3, 1, "18B" },
                    { 465, 3, 1, "18C" },
                    { 466, 3, 1, "18D" },
                    { 467, 3, 1, "18E" },
                    { 468, 3, 1, "18F" },
                    { 469, 3, 1, "19A" },
                    { 470, 3, 1, "19B" },
                    { 471, 3, 1, "19C" },
                    { 472, 3, 1, "19D" },
                    { 473, 3, 1, "19E" },
                    { 474, 3, 1, "19F" },
                    { 475, 3, 1, "20A" },
                    { 476, 3, 1, "20B" },
                    { 477, 3, 1, "20C" },
                    { 478, 3, 1, "20D" },
                    { 479, 3, 1, "20E" },
                    { 480, 3, 1, "20F" },
                    { 481, 3, 1, "21A" },
                    { 482, 3, 1, "21B" },
                    { 483, 3, 1, "21C" },
                    { 484, 3, 1, "21D" },
                    { 485, 3, 1, "21E" },
                    { 486, 3, 1, "21F" },
                    { 487, 3, 1, "22A" },
                    { 488, 3, 1, "22B" },
                    { 489, 3, 1, "22C" },
                    { 490, 3, 1, "22D" },
                    { 491, 3, 1, "22E" },
                    { 492, 3, 1, "22F" },
                    { 493, 3, 1, "23A" },
                    { 494, 3, 1, "23B" },
                    { 495, 3, 1, "23C" },
                    { 496, 3, 1, "23D" },
                    { 497, 3, 1, "23E" },
                    { 498, 3, 1, "23F" },
                    { 499, 3, 1, "24A" },
                    { 500, 3, 1, "24B" },
                    { 501, 3, 1, "24C" },
                    { 502, 3, 1, "24D" },
                    { 503, 3, 1, "24E" },
                    { 504, 3, 1, "24F" },
                    { 505, 3, 1, "25A" },
                    { 506, 3, 1, "25B" },
                    { 507, 3, 1, "25C" },
                    { 508, 3, 1, "25D" },
                    { 509, 3, 1, "25E" },
                    { 510, 3, 1, "25F" },
                    { 511, 3, 1, "26A" },
                    { 512, 3, 1, "26B" },
                    { 513, 3, 1, "26C" },
                    { 514, 3, 1, "26D" },
                    { 515, 3, 1, "26E" },
                    { 516, 3, 1, "26F" },
                    { 517, 3, 1, "27A" },
                    { 518, 3, 1, "27B" },
                    { 519, 3, 1, "27C" },
                    { 520, 3, 1, "27D" },
                    { 521, 3, 1, "27E" },
                    { 522, 3, 1, "27F" },
                    { 523, 3, 1, "28A" },
                    { 524, 3, 1, "28B" },
                    { 525, 3, 1, "28C" },
                    { 526, 3, 1, "28D" },
                    { 527, 3, 1, "28E" },
                    { 528, 3, 1, "28F" },
                    { 529, 3, 1, "29A" },
                    { 530, 3, 1, "29B" },
                    { 531, 3, 1, "29C" },
                    { 532, 3, 1, "29D" },
                    { 533, 3, 1, "29E" },
                    { 534, 3, 1, "29F" },
                    { 535, 3, 1, "30A" },
                    { 536, 3, 1, "30B" },
                    { 537, 3, 1, "30C" },
                    { 538, 3, 1, "30D" },
                    { 539, 3, 1, "30E" },
                    { 540, 3, 1, "30F" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_AirportId",
                table: "Airlines",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirlineId",
                table: "Airplanes",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_ReservationId",
                table: "CheckIns",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_SeatId",
                table: "CheckIns",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_UserId",
                table: "CheckIns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailConfirmations_UserId",
                table: "EmailConfirmations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AirportId",
                table: "Employees",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReviews_FlightId",
                table: "FlightReviews",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReviews_UserId",
                table: "FlightReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirlineId",
                table: "Flights",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_LuggageReports_EmployeeId",
                table: "LuggageReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LuggageReports_LuggageId",
                table: "LuggageReports",
                column: "LuggageId");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_AirportId",
                table: "Luggages",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_FlightId",
                table: "Luggages",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_UserId",
                table: "Luggages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AirplaneId",
                table: "Reservations",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AirportId",
                table: "Reservations",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightId",
                table: "Reservations",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MealTypeId",
                table: "Reservations",
                column: "MealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PaymentId",
                table: "Reservations",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_AirplaneId",
                table: "Seats",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SeatClassId",
                table: "Seats",
                column: "SeatClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckIns");

            migrationBuilder.DropTable(
                name: "EmailConfirmations");

            migrationBuilder.DropTable(
                name: "FlightReviews");

            migrationBuilder.DropTable(
                name: "LuggageReports");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Luggages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "MealTypes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "SeatClasses");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Airports");
        }
    }
}
