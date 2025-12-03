using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddAirplaneIdToReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "AirplaneId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AirplaneId",
                table: "Reservations",
                column: "AirplaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Airplanes_AirplaneId",
                table: "Reservations",
                column: "AirplaneId",
                principalTable: "Airplanes",
                principalColumn: "airplane_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_MealTypes",
                table: "Reservations",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "MealTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Airplanes_AirplaneId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_MealTypes",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_AirplaneId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "AirplaneId",
                table: "Reservations");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeId",
                table: "Reservations",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "MealTypeId");
        }
    }
}
