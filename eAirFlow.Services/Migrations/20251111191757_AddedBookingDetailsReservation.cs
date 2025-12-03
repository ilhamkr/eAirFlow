using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookingDetailsReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Adults",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Children",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LuggageOption",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MealType",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatClassId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeatNumber",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adults",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Children",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "LuggageOption",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "MealType",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SeatClassId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "Reservations");
        }
    }
}
