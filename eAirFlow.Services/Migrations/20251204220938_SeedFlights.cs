using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class SeedFlights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 4, 22, 9, 37, 971, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "AirlineId", "AirplaneId", "ArrivalLocation", "ArrivalTime", "DepartureLocation", "DepartureTime", "Price", "StateMachine" },
                values: new object[,]
                {
                    { 1, 1, 1, "Istanbul", new DateTime(2025, 12, 4, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 4, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 2, 1, 1, "Berlin", new DateTime(2025, 12, 4, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 4, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 3, 1, 1, "Roma", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 4, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 4, 1, 1, "Paris", new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 4, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 5, 1, 1, "Munich", new DateTime(2025, 12, 4, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 4, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 6, 1, 1, "Frankfurt", new DateTime(2025, 12, 4, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 4, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 7, 1, 1, "Istanbul", new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 8, 1, 1, "Berlin", new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 9, 1, 1, "Roma", new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 10, 1, 1, "Paris", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 11, 1, 1, "Munich", new DateTime(2025, 12, 5, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 12, 1, 1, "Frankfurt", new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 13, 1, 1, "Istanbul", new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 14, 1, 1, "Berlin", new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 15, 1, 1, "Roma", new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 16, 1, 1, "Paris", new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 17, 1, 1, "Munich", new DateTime(2025, 12, 6, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 18, 1, 1, "Frankfurt", new DateTime(2025, 12, 6, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 19, 1, 1, "Istanbul", new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 20, 1, 1, "Berlin", new DateTime(2025, 12, 7, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 21, 1, 1, "Roma", new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 22, 1, 1, "Paris", new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 7, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 23, 1, 1, "Munich", new DateTime(2025, 12, 7, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 24, 1, 1, "Frankfurt", new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 25, 1, 1, "Istanbul", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 26, 1, 1, "Berlin", new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 27, 1, 1, "Roma", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 28, 1, 1, "Paris", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 29, 1, 1, "Munich", new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 30, 1, 1, "Frankfurt", new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 31, 1, 1, "Istanbul", new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 32, 1, 1, "Berlin", new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 33, 1, 1, "Roma", new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 34, 1, 1, "Paris", new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 9, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 35, 1, 1, "Munich", new DateTime(2025, 12, 9, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 9, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 36, 1, 1, "Frankfurt", new DateTime(2025, 12, 9, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 9, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 37, 1, 1, "Istanbul", new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 38, 1, 1, "Berlin", new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 39, 1, 1, "Roma", new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 40, 1, 1, "Paris", new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 41, 1, 1, "Munich", new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 42, 1, 1, "Frankfurt", new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 43, 1, 1, "Istanbul", new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 44, 1, 1, "Berlin", new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 45, 1, 1, "Roma", new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 46, 1, 1, "Paris", new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 11, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 47, 1, 1, "Munich", new DateTime(2025, 12, 11, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 48, 1, 1, "Frankfurt", new DateTime(2025, 12, 11, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 11, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 49, 1, 1, "Istanbul", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 50, 1, 1, "Berlin", new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 51, 1, 1, "Roma", new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 52, 1, 1, "Paris", new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 12, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 53, 1, 1, "Munich", new DateTime(2025, 12, 12, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 12, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 54, 1, 1, "Frankfurt", new DateTime(2025, 12, 12, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 12, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 55, 1, 1, "Istanbul", new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 56, 1, 1, "Berlin", new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 57, 1, 1, "Roma", new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 58, 1, 1, "Paris", new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 13, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 59, 1, 1, "Munich", new DateTime(2025, 12, 13, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 60, 1, 1, "Frankfurt", new DateTime(2025, 12, 13, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 13, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 61, 1, 1, "Istanbul", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 62, 1, 1, "Berlin", new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 63, 1, 1, "Roma", new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 64, 1, 1, "Paris", new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 14, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 65, 1, 1, "Munich", new DateTime(2025, 12, 14, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 14, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 66, 1, 1, "Frankfurt", new DateTime(2025, 12, 14, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 14, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 67, 1, 1, "Istanbul", new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 68, 1, 1, "Berlin", new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 69, 1, 1, "Roma", new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 70, 1, 1, "Paris", new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 15, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 71, 1, 1, "Munich", new DateTime(2025, 12, 15, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 15, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 72, 1, 1, "Frankfurt", new DateTime(2025, 12, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 15, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 73, 1, 1, "Istanbul", new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 74, 1, 1, "Berlin", new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 75, 1, 1, "Roma", new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 76, 1, 1, "Paris", new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 16, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 77, 1, 1, "Munich", new DateTime(2025, 12, 16, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 16, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 78, 1, 1, "Frankfurt", new DateTime(2025, 12, 16, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 16, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 79, 1, 1, "Istanbul", new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 80, 1, 1, "Berlin", new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 81, 1, 1, "Roma", new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 82, 1, 1, "Paris", new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 17, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 83, 1, 1, "Munich", new DateTime(2025, 12, 17, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 84, 1, 1, "Frankfurt", new DateTime(2025, 12, 17, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 17, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 85, 1, 1, "Istanbul", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 86, 1, 1, "Berlin", new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 87, 1, 1, "Roma", new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 88, 1, 1, "Paris", new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 18, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 89, 1, 1, "Munich", new DateTime(2025, 12, 18, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 18, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 90, 1, 1, "Frankfurt", new DateTime(2025, 12, 18, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 18, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 91, 1, 1, "Istanbul", new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 92, 1, 1, "Berlin", new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 93, 1, 1, "Roma", new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 94, 1, 1, "Paris", new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 19, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 95, 1, 1, "Munich", new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 96, 1, 1, "Frankfurt", new DateTime(2025, 12, 19, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 19, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 97, 1, 1, "Istanbul", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 98, 1, 1, "Berlin", new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 99, 1, 1, "Roma", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 100, 1, 1, "Paris", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 20, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 101, 1, 1, "Munich", new DateTime(2025, 12, 20, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 102, 1, 1, "Frankfurt", new DateTime(2025, 12, 20, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 20, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 103, 1, 1, "Istanbul", new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 104, 1, 1, "Berlin", new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 105, 1, 1, "Roma", new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 106, 1, 1, "Paris", new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 21, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 107, 1, 1, "Munich", new DateTime(2025, 12, 21, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 21, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 108, 1, 1, "Frankfurt", new DateTime(2025, 12, 21, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 21, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 109, 1, 1, "Istanbul", new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 110, 1, 1, "Berlin", new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 111, 1, 1, "Roma", new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 112, 1, 1, "Paris", new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 22, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 113, 1, 1, "Munich", new DateTime(2025, 12, 22, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 114, 1, 1, "Frankfurt", new DateTime(2025, 12, 22, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 22, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" },
                    { 115, 1, 1, "Istanbul", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 8, 0, 0, 0, DateTimeKind.Utc), 150, "scheduled" },
                    { 116, 1, 1, "Berlin", new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 9, 0, 0, 0, DateTimeKind.Utc), 155, "scheduled" },
                    { 117, 1, 1, "Roma", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 10, 0, 0, 0, DateTimeKind.Utc), 160, "scheduled" },
                    { 118, 1, 1, "Paris", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), "Sarajevo", new DateTime(2025, 12, 23, 11, 0, 0, 0, DateTimeKind.Utc), 165, "scheduled" },
                    { 119, 1, 1, "Munich", new DateTime(2025, 12, 23, 14, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 12, 0, 0, 0, DateTimeKind.Utc), 130, "scheduled" },
                    { 120, 1, 1, "Frankfurt", new DateTime(2025, 12, 23, 15, 0, 0, 0, DateTimeKind.Utc), "Mostar", new DateTime(2025, 12, 23, 13, 0, 0, 0, DateTimeKind.Utc), 140, "scheduled" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 120);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3245), "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3268), "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3284), "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==" });
        }
    }
}
