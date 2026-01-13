using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class timezone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArrivalTimeZone",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartureTimeZone",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "ArrivalTimeZone", "DepartureTimeZone" },
                values: new object[] { null, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTimeZone",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureTimeZone",
                table: "Flights");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 12, 20, 33, 13, 971, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 20, 33, 13, 971, DateTimeKind.Utc).AddTicks(26), "fFsqpZ5cUp7tEjTMpLAKbc35gesEQduWVz42Q5lM0Ek=", "hMbIFHhP2J+Yz5CVOuet1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 20, 33, 13, 971, DateTimeKind.Utc).AddTicks(50), "fFsqpZ5cUp7tEjTMpLAKbc35gesEQduWVz42Q5lM0Ek=", "hMbIFHhP2J+Yz5CVOuet1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 20, 33, 13, 971, DateTimeKind.Utc).AddTicks(65), "fFsqpZ5cUp7tEjTMpLAKbc35gesEQduWVz42Q5lM0Ek=", "hMbIFHhP2J+Yz5CVOuet1g==" });
        }
    }
}
