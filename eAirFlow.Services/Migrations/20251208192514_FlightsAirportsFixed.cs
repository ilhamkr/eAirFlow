using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class FlightsAirportsFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirportId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 8, 19, 25, 13, 359, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 25, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 25, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 26, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 26, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "AirportId", "ArrivalTime", "DepartureTime" },
                values: new object[] { null, new DateTime(2025, 12, 27, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 27, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 25, 13, 359, DateTimeKind.Utc).AddTicks(2239), "QwDUuZRDQF4548fUfGqQXWbdAC/axX1uPEHH0GXWx/8=", "PCH6i9Gzb+3T9uLcF8fhdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 25, 13, 359, DateTimeKind.Utc).AddTicks(2263), "QwDUuZRDQF4548fUfGqQXWbdAC/axX1uPEHH0GXWx/8=", "PCH6i9Gzb+3T9uLcF8fhdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 25, 13, 359, DateTimeKind.Utc).AddTicks(2277), "QwDUuZRDQF4548fUfGqQXWbdAC/axX1uPEHH0GXWx/8=", "PCH6i9Gzb+3T9uLcF8fhdA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirportId",
                table: "Flights",
                column: "AirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airports_AirportId",
                table: "Flights",
                column: "AirportId",
                principalTable: "Airports",
                principalColumn: "AirportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airports_AirportId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_AirportId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Flights");

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 6, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc) });

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
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2025, 12, 24, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 12, 24, 13, 0, 0, 0, DateTimeKind.Utc) });

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
    }
}
