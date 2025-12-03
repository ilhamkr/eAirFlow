using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToCheckIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CheckIns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_UserId",
                table: "CheckIns",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Users_UserId",
                table: "CheckIns",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Users_UserId",
                table: "CheckIns");

            migrationBuilder.DropIndex(
                name: "IX_CheckIns_UserId",
                table: "CheckIns");

            migrationBuilder.DropColumn(
                name: "IsSeen",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CheckIns");
        }
    }
}
