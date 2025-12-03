using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class FixAirportMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Airport",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "AirportId",
                table: "Reservations",
                newName: "airport_id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_AirportId",
                table: "Reservations",
                newName: "IX_Reservations_airport_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Airports",
                table: "Reservations",
                column: "airport_id",
                principalTable: "Airports",
                principalColumn: "AirportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Airports",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "airport_id",
                table: "Reservations",
                newName: "AirportId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_airport_id",
                table: "Reservations",
                newName: "IX_Reservations_AirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Airport",
                table: "Reservations",
                column: "AirportId",
                principalTable: "Airports",
                principalColumn: "AirportId");
        }
    }
}
