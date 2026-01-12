using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class timezones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneId",
                table: "Airports",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "TimeZones",
                columns: table => new
                {
                    TimeZoneId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZones", x => x.TimeZoneId);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 12, 15, 22, 53, 688, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 31, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 31, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "TimeZoneId", "DisplayName" },
                values: new object[,]
                {
                    { "Africa/Johannesburg", "African" },
                    { "America/New_York", "American" },
                    { "Asia/Tokyo", "Asian" },
                    { "Europe/Sarajevo", "European" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 22, 53, 688, DateTimeKind.Utc).AddTicks(7763), "PlgXSQ5J3jNOFQ5Vtaxu2F7zvU2kPt8kqAZaTmYnKXM=", "YRmxOq+Xr4BBeuJBY8kveQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 22, 53, 688, DateTimeKind.Utc).AddTicks(7788), "PlgXSQ5J3jNOFQ5Vtaxu2F7zvU2kPt8kqAZaTmYnKXM=", "YRmxOq+Xr4BBeuJBY8kveQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 22, 53, 688, DateTimeKind.Utc).AddTicks(7805), "PlgXSQ5J3jNOFQ5Vtaxu2F7zvU2kPt8kqAZaTmYnKXM=", "YRmxOq+Xr4BBeuJBY8kveQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Airports_TimeZoneId",
                table: "Airports",
                column: "TimeZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_TimeZones_TimeZoneId",
                table: "Airports",
                column: "TimeZoneId",
                principalTable: "TimeZones",
                principalColumn: "TimeZoneId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_TimeZones_TimeZoneId",
                table: "Airports");

            migrationBuilder.DropTable(
                name: "TimeZones");

            migrationBuilder.DropIndex(
                name: "IX_Airports_TimeZoneId",
                table: "Airports");

            migrationBuilder.AlterColumn<string>(
                name: "TimeZoneId",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 11, 14, 39, 2, 587, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 11, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 11, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 12, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 12, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 13, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 13, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 14, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 15, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 15, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 16, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 16, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 17, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 17, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 18, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 18, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 19, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 19, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 20, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 20, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 21, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 21, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 22, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 22, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 23, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 23, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 121,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 122,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 123,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 124,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 125,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 126,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 24, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 24, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 127,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 128,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 129,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 130,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 131,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 132,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 133,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 134,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 135,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 25, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 25, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 136,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 137,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 138,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 139,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 140,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 141,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 142,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 143,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 144,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 26, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 26, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 145,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 146,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 147,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 148,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 149,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 150,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 151,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 152,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 153,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 27, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 27, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 154,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 155,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 156,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 157,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 158,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 159,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 160,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 161,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 162,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 28, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 28, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 163,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 164,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 165,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 166,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 167,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 168,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 169,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 170,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 171,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 29, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 29, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 172,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 173,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 174,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 175,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 176,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 177,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 18, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 16, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 178,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 179,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 14, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 12, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 180,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2026, 1, 30, 15, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 30, 13, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 39, 2, 587, DateTimeKind.Utc).AddTicks(6950), "VgrQ5+9fW6F7haZlQCYaL35fBJjyvah2ALY9qyCICXQ=", "IadTlN3vTHYgY4GMxHgxug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 39, 2, 587, DateTimeKind.Utc).AddTicks(6975), "VgrQ5+9fW6F7haZlQCYaL35fBJjyvah2ALY9qyCICXQ=", "IadTlN3vTHYgY4GMxHgxug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 1, 11, 14, 39, 2, 587, DateTimeKind.Utc).AddTicks(6990), "VgrQ5+9fW6F7haZlQCYaL35fBJjyvah2ALY9qyCICXQ=", "IadTlN3vTHYgY4GMxHgxug==" });
        }
    }
}
