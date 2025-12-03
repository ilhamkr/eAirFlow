using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class UserEmployeeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightIssues");

            migrationBuilder.AlterColumn<DateTime>(
                name: "hire_date",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_user_id",
                table: "Employees",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users",
                table: "Employees",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_user_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Employees");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "hire_date",
                table: "Employees",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FlightIssues",
                columns: table => new
                {
                    issue_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    reported_by = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    reported_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FlightIs__D6185C393F7EBB2B", x => x.issue_id);
                    table.ForeignKey(
                        name: "FK_Issues_Employees",
                        column: x => x.reported_by,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_Issues_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightIssues_flight_id",
                table: "FlightIssues",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightIssues_reported_by",
                table: "FlightIssues",
                column: "reported_by");
        }
    }
}
