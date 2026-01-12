using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class timezonesremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_TimeZones_TimeZoneId",
                table: "Airports");

            migrationBuilder.DropTable(
                name: "TimeZones");

            migrationBuilder.DropIndex(
                name: "IX_Airports_TimeZoneId",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "TimeZoneId",
                table: "Airports");

            migrationBuilder.AddColumn<string>(
                name: "TimeZone",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Airports");

            migrationBuilder.AddColumn<string>(
                name: "TimeZoneId",
                table: "Airports",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

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
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 1,
                column: "TimeZoneId",
                value: "Europe/Sarajevo");

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 2,
                column: "TimeZoneId",
                value: "Europe/Sarajevo");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2026, 1, 12, 15, 22, 53, 688, DateTimeKind.Utc).AddTicks(7865));

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
    }
}
