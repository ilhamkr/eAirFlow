using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddingMealTypeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MealTypeId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.MealTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MealTypeId",
                table: "Reservations",
                column: "MealTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeId",
                table: "Reservations",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "MealTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_MealTypes_MealTypeId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "MealTypes");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_MealTypeId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "MealTypeId",
                table: "Reservations");
        }
    }
}
