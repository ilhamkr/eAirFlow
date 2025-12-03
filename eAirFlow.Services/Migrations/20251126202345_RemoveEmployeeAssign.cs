using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEmployeeAssign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeAssignments");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId1",
                table: "Employees",
                column: "UserId1",
                unique: true,
                filter: "[UserId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId1",
                table: "Employees",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeAssignments",
                columns: table => new
                {
                    assignment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    assigned_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    job_role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    job_scope = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__DA891814BFC506B5", x => x.assignment_id);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_Assignments_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_employee_id",
                table: "EmployeeAssignments",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_flight_id",
                table: "EmployeeAssignments",
                column: "flight_id");
        }
    }
}
