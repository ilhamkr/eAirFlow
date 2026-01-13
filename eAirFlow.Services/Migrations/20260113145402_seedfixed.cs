using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class seedfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "AirlineId", "AirportId", "Country", "Name" },
                values: new object[,]
                {
                    { 7, 2, "Germany", "Lufthansa" },
                    { 10, 1, "Hungary", "WizzAir" }
                });

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 3,
                column: "AirlineId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 1,
                column: "TimeZone",
                value: "Europe/Sarajevo");

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 2,
                column: "TimeZone",
                value: "Europe/Sarajevo");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 13, 14, 54, 1, 904, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 13, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { "Rome", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 13, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, "Munich", new DateTime(2026, 1, 13, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 14, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 16, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 16, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 17, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 18, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 18, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 19, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 20, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 20, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, "Frankfurt", new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 21, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 21, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { "Rome", "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { 7, new DateTime(2026, 1, 21, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { 7, "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { "Rome", "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, "Munich", new DateTime(2026, 1, 22, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 23, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 23, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 23, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", "Europe/Moscow", new DateTime(2026, 1, 24, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 24, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 24, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 24, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 25, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 25, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 26, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 26, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "New York", new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 27, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", new DateTime(2026, 1, 28, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 28, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Rome", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 28, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Rome", new DateTime(2026, 1, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 28, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Frankfurt", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 29, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 29, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, 3, "Munich", new DateTime(2026, 1, 29, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 7, "Frankfurt", new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 30, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Rome", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "New York", new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { "Rome", new DateTime(2026, 1, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { 7, new DateTime(2026, 1, 30, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { 7, new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price", "StateMachine" },
                values: new object[,]
                {
                    { 181, 1, 1, "Istanbul", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 182, 1, 1, "Berlin", new DateTime(2026, 1, 31, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 183, 1, 1, "Rome", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 184, 1, 1, "Paris", new DateTime(2026, 1, 31, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 185, 1, 1, "New York", new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 186, 2, 2, "Berlin", new DateTime(2026, 1, 31, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 187, 2, 2, "Rome", new DateTime(2026, 1, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 188, 2, 2, "Paris", new DateTime(2026, 1, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" },
                    { 191, 1, 1, "Istanbul", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Moscow", "Sarajevo", new DateTime(2026, 2, 1, 8, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 150, "scheduled" },
                    { 192, 1, 1, "Berlin", new DateTime(2026, 2, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 9, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 155, "scheduled" },
                    { 193, 1, 1, "Rome", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 10, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 160, "scheduled" },
                    { 194, 1, 1, "Paris", new DateTime(2026, 2, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 11, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 165, "scheduled" },
                    { 195, 1, 1, "New York", new DateTime(2026, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "America/New_York", "Sarajevo", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 170, "scheduled" },
                    { 196, 2, 2, "Berlin", new DateTime(2026, 2, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 15, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 90, "scheduled" },
                    { 197, 2, 2, "Rome", new DateTime(2026, 2, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 16, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 97, "scheduled" },
                    { 198, 2, 2, "Paris", new DateTime(2026, 2, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Sarajevo", new DateTime(2026, 2, 1, 17, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 104, "scheduled" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 54, 1, 904, DateTimeKind.Utc).AddTicks(4060), "gef3w2wlvcMs9OULRp/FfYBiOYsheGUlXXxtwQ7ZMIA=", "agB87CEIe3JaRYOaOW/Zow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 54, 1, 904, DateTimeKind.Utc).AddTicks(4083), "gef3w2wlvcMs9OULRp/FfYBiOYsheGUlXXxtwQ7ZMIA=", "agB87CEIe3JaRYOaOW/Zow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 54, 1, 904, DateTimeKind.Utc).AddTicks(4097), "gef3w2wlvcMs9OULRp/FfYBiOYsheGUlXXxtwQ7ZMIA=", "agB87CEIe3JaRYOaOW/Zow==" });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "AirlineId", "Model", "TotalSeats" },
                values: new object[] { 4, 10, "Airbus A321", 200 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price", "StateMachine" },
                values: new object[,]
                {
                    { 189, 7, 3, "Munich", new DateTime(2026, 1, 31, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 190, 7, 3, "Frankfurt", new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" },
                    { 199, 7, 3, "Munich", new DateTime(2026, 2, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 2, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 130, "scheduled" },
                    { 200, 7, 3, "Frankfurt", new DateTime(2026, 2, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "Europe/Sarajevo", "Mostar", new DateTime(2026, 2, 1, 13, 0, 0, 0, DateTimeKind.Utc), "Europe/Sarajevo", 140, "scheduled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "AirlineId", "AirportId", "Country", "Name" },
                values: new object[] { 3, 2, "Germany", "Lufthansa" });

            migrationBuilder.UpdateData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 3,
                column: "AirlineId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 1,
                column: "TimeZone",
                value: "");

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 2,
                column: "TimeZone",
                value: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 12, 21, 45, 4, 675, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 8, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 9, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { "Roma", new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 12, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 12, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 12, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, "Frankfurt", new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 13, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 13, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 13, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 14, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 14, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 14, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 15, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 15, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 16, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 16, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 16, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 17, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 17, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 17, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 18, 18, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 18, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 18, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 19, 18, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 19, 19, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 19, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 20, 19, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, "Munich", new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 21, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { "Roma", null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 21, 19, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { 3, new DateTime(2026, 1, 21, 14, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { 3, null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { "Roma", null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 22, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 22, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 22, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, "Frankfurt", new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 23, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 23, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 23, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 23, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 24, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 24, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalLocation", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", null, new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 24, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 24, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 24, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 25, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 25, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 25, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, new DateTime(2026, 1, 25, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 25, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 26, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 26, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 26, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 26, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 26, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 27, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 27, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 27, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 28, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 28, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 28, 18, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 28, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 28, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 29, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 29, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2026, 1, 29, 18, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 29, 19, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2026, 1, 29, 14, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 1, 1, "Paris", new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), null, 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 30, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Utc), null, 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2026, 1, 30, 19, 0, 0, 0, DateTimeKind.Utc), null, "Sarajevo", new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), null, 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "AirlineId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, "Munich", new DateTime(2026, 1, 30, 14, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), null, 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureLocation", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), null, "Mostar", new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), null, 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Istanbul", new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Utc), null, 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Berlin", new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 9, 0, 0, 0, DateTimeKind.Utc), null, 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Roma", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc), null, 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone", "Price" },
                values: new object[] { "Paris", new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc), null, 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { "Roma", new DateTime(2026, 1, 31, 18, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { new DateTime(2026, 1, 31, 19, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { 3, new DateTime(2026, 1, 31, 14, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "AirlineId", "ArrivalTime", "ArrivalTimeZone", "DepartureTime", "DepartureTimeZone" },
                values: new object[] { 3, new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 21, 45, 4, 675, DateTimeKind.Utc).AddTicks(4434), "hCfS+6OPXFnIqAGDgnW6kYlr+lzNqKJzjvfgTiz8tkY=", "QrmfSrXIc5BCacU4CZDW/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 21, 45, 4, 675, DateTimeKind.Utc).AddTicks(4457), "hCfS+6OPXFnIqAGDgnW6kYlr+lzNqKJzjvfgTiz8tkY=", "QrmfSrXIc5BCacU4CZDW/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 21, 45, 4, 675, DateTimeKind.Utc).AddTicks(4472), "hCfS+6OPXFnIqAGDgnW6kYlr+lzNqKJzjvfgTiz8tkY=", "QrmfSrXIc5BCacU4CZDW/A==" });
        }
    }
}
