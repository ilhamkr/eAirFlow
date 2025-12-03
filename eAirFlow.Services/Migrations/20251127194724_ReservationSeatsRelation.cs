using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class ReservationSeatsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatReservations");

            migrationBuilder.DropColumn(
                name: "SeatNumber",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "SeatClassId",
                table: "Reservations",
                newName: "SeatId");

            migrationBuilder.Sql(@"
            UPDATE Reservations
             SET SeatId = NULL
            WHERE SeatId IS NOT NULL
            ");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Seats",
                table: "Reservations",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "seat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Seats",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Reservations",
                newName: "SeatClassId");

            migrationBuilder.AddColumn<string>(
                name: "SeatNumber",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SeatReservations",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false),
                    seat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SeatRese__E83E92F0F662B9A7", x => new { x.reservation_id, x.seat_id });
                    table.ForeignKey(
                        name: "FK_SeatReservations_Reservations",
                        column: x => x.reservation_id,
                        principalTable: "Reservations",
                        principalColumn: "reservation_id");
                    table.ForeignKey(
                        name: "FK_SeatReservations_Seats",
                        column: x => x.seat_id,
                        principalTable: "Seats",
                        principalColumn: "seat_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_seat_id",
                table: "SeatReservations",
                column: "seat_id");
        }
    }
}
