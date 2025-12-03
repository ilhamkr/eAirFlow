using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class FixUserEmployeeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_user_id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserId1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_user_id",
                table: "Employees",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_user_id",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_user_id",
                table: "Employees",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId1",
                table: "Employees",
                column: "UserId1",
                unique: true,
                filter: "[UserId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId1",
                table: "Employees",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "user_id");
        }
    }
}
