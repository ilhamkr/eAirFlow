using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AirplaneAirlineRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Airplanes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_AirlineId",
                table: "Airplanes",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airplanes_Airlines_AirlineId",
                table: "Airplanes",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "airline_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airplanes_Airlines_AirlineId",
                table: "Airplanes");

            migrationBuilder.DropIndex(
                name: "IX_Airplanes_AirlineId",
                table: "Airplanes");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Airplanes");
        }
    }
}
