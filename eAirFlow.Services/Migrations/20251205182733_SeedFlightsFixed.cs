using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class SeedFlightsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 5, 18, 27, 32, 736, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 5, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 5, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 5, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 6, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "AirplaneId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "AirplaneId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 7, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 7, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 9, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 11, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 11, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 13, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 13, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 14, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 15, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 16, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, new DateTime(2025, 12, 16, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 16, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 3, 3, new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Berlin", new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), 90 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Roma", new DateTime(2025, 12, 17, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc), 97 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 2, 2, "Paris", new DateTime(2025, 12, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), 104 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Munich", new DateTime(2025, 12, 17, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 3, 3, "Frankfurt", new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Berlin", new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Roma", new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price", "StateMachine" },
                values: new object[,]
                {
                    { 121, 1, 1, "Paris", new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 122, 2, 2, "Berlin", new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 123, 2, 2, "Roma", new DateTime(2025, 12, 18, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 124, 2, 2, "Paris", new DateTime(2025, 12, 18, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 125, 3, 3, "Munich", new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 126, 3, 3, "Frankfurt", new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 127, 1, 1, "Istanbul", new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 128, 1, 1, "Berlin", new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 129, 1, 1, "Roma", new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 130, 1, 1, "Paris", new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 131, 2, 2, "Berlin", new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 132, 2, 2, "Roma", new DateTime(2025, 12, 19, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 133, 2, 2, "Paris", new DateTime(2025, 12, 19, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 134, 3, 3, "Munich", new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 135, 3, 3, "Frankfurt", new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 136, 1, 1, "Istanbul", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 137, 1, 1, "Berlin", new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 138, 1, 1, "Roma", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 139, 1, 1, "Paris", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 140, 2, 2, "Berlin", new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 141, 2, 2, "Roma", new DateTime(2025, 12, 20, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 142, 2, 2, "Paris", new DateTime(2025, 12, 20, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 143, 3, 3, "Munich", new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 144, 3, 3, "Frankfurt", new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 145, 1, 1, "Istanbul", new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 146, 1, 1, "Berlin", new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 147, 1, 1, "Roma", new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 148, 1, 1, "Paris", new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 149, 2, 2, "Berlin", new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 150, 2, 2, "Roma", new DateTime(2025, 12, 21, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 151, 2, 2, "Paris", new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 152, 3, 3, "Munich", new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 153, 3, 3, "Frankfurt", new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 154, 1, 1, "Istanbul", new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 155, 1, 1, "Berlin", new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 156, 1, 1, "Roma", new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 157, 1, 1, "Paris", new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 158, 2, 2, "Berlin", new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 159, 2, 2, "Roma", new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 160, 2, 2, "Paris", new DateTime(2025, 12, 22, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 161, 3, 3, "Munich", new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 162, 3, 3, "Frankfurt", new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 163, 1, 1, "Istanbul", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 164, 1, 1, "Berlin", new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 165, 1, 1, "Roma", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 166, 1, 1, "Paris", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 167, 2, 2, "Berlin", new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 168, 2, 2, "Roma", new DateTime(2025, 12, 23, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 169, 2, 2, "Paris", new DateTime(2025, 12, 23, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 170, 3, 3, "Munich", new DateTime(2025, 12, 23, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 171, 3, 3, "Frankfurt", new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 172, 1, 1, "Istanbul", new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 173, 1, 1, "Berlin", new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 174, 1, 1, "Roma", new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 175, 1, 1, "Paris", new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 176, 2, 2, "Berlin", new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc), 90, "scheduled" },
                    { 177, 2, 2, "Roma", new DateTime(2025, 12, 24, 18, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 16, 0, 0, 0, DateTimeKind.Utc), 97, "scheduled" },
                    { 178, 2, 2, "Paris", new DateTime(2025, 12, 24, 19, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), 104, "scheduled" },
                    { 179, 3, 3, "Munich", new DateTime(2025, 12, 24, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 180, 3, 3, "Frankfurt", new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 27, 32, 736, DateTimeKind.Utc).AddTicks(9087), "yRCgMCahqz8P2rVcvwaqqNOg01zSfTHQYCjH7ocSswM=", "oMuv2IaA237OaGMjh9Mv4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 27, 32, 736, DateTimeKind.Utc).AddTicks(9110), "yRCgMCahqz8P2rVcvwaqqNOg01zSfTHQYCjH7ocSswM=", "oMuv2IaA237OaGMjh9Mv4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 27, 32, 736, DateTimeKind.Utc).AddTicks(9126), "yRCgMCahqz8P2rVcvwaqqNOg01zSfTHQYCjH7ocSswM=", "oMuv2IaA237OaGMjh9Mv4Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 4, 22, 9, 37, 971, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 4, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 4, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 4, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 4, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 5, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "AirplaneId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "AirplaneId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 7, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 11, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 13, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 16, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 17, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Istanbul", new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalTime", "DepartureTime" },
                values: new object[] { 1, 1, new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Munich", new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Frankfurt", new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Istanbul", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), 150 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Berlin", new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc), 155 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { 1, 1, "Roma", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), 160 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureTime", "Price" },
                values: new object[] { "Paris", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), 165 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Munich", new DateTime(2025, 12, 23, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), 130 });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price" },
                values: new object[] { "Frankfurt", new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), 140 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 9, 37, 971, DateTimeKind.Utc).AddTicks(7251), "3c+k5M5gyFZ+Mnj/WyOX01eXdTKws8oS2uklKDkA0zY=", "iMt0VwDW2eKAPcZ1syky+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 9, 37, 971, DateTimeKind.Utc).AddTicks(7274), "3c+k5M5gyFZ+Mnj/WyOX01eXdTKws8oS2uklKDkA0zY=", "iMt0VwDW2eKAPcZ1syky+g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 9, 37, 971, DateTimeKind.Utc).AddTicks(7288), "3c+k5M5gyFZ+Mnj/WyOX01eXdTKws8oS2uklKDkA0zY=", "iMt0VwDW2eKAPcZ1syky+g==" });
        }
    }
}
