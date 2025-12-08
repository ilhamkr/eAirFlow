using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class FlightsAirportsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 8, 19, 28, 23, 872, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 28, 23, 872, DateTimeKind.Utc).AddTicks(8841), "jZrOC6CYFypqOeB8enFGThCovTPl4KdHS5C0K6JIhOM=", "BDvRAIAwklz5V63ZSgrzBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 28, 23, 872, DateTimeKind.Utc).AddTicks(8862), "jZrOC6CYFypqOeB8enFGThCovTPl4KdHS5C0K6JIhOM=", "BDvRAIAwklz5V63ZSgrzBQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 28, 23, 872, DateTimeKind.Utc).AddTicks(8876), "jZrOC6CYFypqOeB8enFGThCovTPl4KdHS5C0K6JIhOM=", "BDvRAIAwklz5V63ZSgrzBQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 12, 8, 19, 25, 13, 359, DateTimeKind.Utc).AddTicks(2335));

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
        }
    }
}
