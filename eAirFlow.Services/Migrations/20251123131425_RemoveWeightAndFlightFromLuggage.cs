using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class RemoveWeightAndFlightFromLuggage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Flights",
                table: "Luggages");

            migrationBuilder.DropColumn(
                name: "weight_kg",
                table: "Luggages");

            migrationBuilder.RenameColumn(
                name: "flight_id",
                table: "Luggages",
                newName: "FlightId");

            migrationBuilder.RenameIndex(
                name: "IX_Luggages_flight_id",
                table: "Luggages",
                newName: "IX_Luggages_FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_Flights_FlightId",
                table: "Luggages",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "flight_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Flights_FlightId",
                table: "Luggages");

            migrationBuilder.RenameColumn(
                name: "FlightId",
                table: "Luggages",
                newName: "flight_id");

            migrationBuilder.RenameIndex(
                name: "IX_Luggages_FlightId",
                table: "Luggages",
                newName: "IX_Luggages_flight_id");

            migrationBuilder.AddColumn<decimal>(
                name: "weight_kg",
                table: "Luggages",
                type: "decimal(5,2)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_Flights",
                table: "Luggages",
                column: "flight_id",
                principalTable: "Flights",
                principalColumn: "flight_id");
        }
    }
}
