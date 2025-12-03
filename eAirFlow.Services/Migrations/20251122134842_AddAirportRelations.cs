using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddAirportRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirportId",
                table: "Luggages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AirportId",
                table: "Airlines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.AirportId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_AirportId",
                table: "Luggages",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_AirportId",
                table: "Airlines",
                column: "AirportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airlines_Airports_AirportId",
                table: "Airlines",
                column: "AirportId",
                principalTable: "Airports",
                principalColumn: "AirportId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_Airports_AirportId",
                table: "Luggages",
                column: "AirportId",
                principalTable: "Airports",
                principalColumn: "AirportId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airlines_Airports_AirportId",
                table: "Airlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Airports_AirportId",
                table: "Luggages");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Luggages_AirportId",
                table: "Luggages");

            migrationBuilder.DropIndex(
                name: "IX_Airlines_AirportId",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Luggages");

            migrationBuilder.DropColumn(
                name: "AirportId",
                table: "Airlines");
        }
    }
}
