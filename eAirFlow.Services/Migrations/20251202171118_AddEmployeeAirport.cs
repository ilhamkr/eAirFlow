using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeAirport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirportId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AirportId",
                table: "Employees",
                column: "AirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airports_AirportId",
                table: "Employees",
                column: "AirportId",
                principalTable: "Airports",
                principalColumn: "AirportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airports_AirportId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AirportId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Employees");
        }
    }
}
