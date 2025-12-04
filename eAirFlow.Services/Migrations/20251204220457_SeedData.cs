using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "AirportId", "City", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Sarajevo", "Bosnia and Herzegovina", "Sarajevo International Airport" },
                    { 2, "Mostar", "Bosnia and Herzegovina", "Mostar International Airport" }
                });

            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "MealTypeId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Standard Meal", 12m },
                    { 2, "Vegetarian", 14m },
                    { 3, "Vegan", 15m }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Handles maintenance and technical operations", "Technician" },
                    { 2, "Manages boarding and gate activities", "Gate Agent" },
                    { 3, "Ensures passenger and airport security", "Security Officer" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Employee" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SeatClasses",
                columns: new[] { "SeatClassId", "Name" },
                values: new object[,]
                {
                    { 1, "Economy" },
                    { 2, "Business" },
                    { 3, "First" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "Name", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfileImageUrl", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3245), "user@example.com", "User", "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==", "555-555", null, "User" },
                    { 2, new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3268), "employee@example.com", "Employee", "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==", "555-555", null, "Employee" },
                    { 3, new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3284), "admin@example.com", "Admin", "SNxSm+PNg5PYMd/7+aXjtrlbK7B9+F4sBkwH/3Wc3Oc=", "Y28LNGlQX/Ddm/ZzBm5hZQ==", "555-555", null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "AirlineId", "AirportId", "Country", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Turkey", "Turkish Airlines" },
                    { 2, 1, "Republic of Ireland", "Ryanair" },
                    { 3, 2, "Germany", "Lufthansa" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AirportId", "Email", "HireDate", "Name", "PhoneNumber", "PositionId", "Surname", "UserId" },
                values: new object[] { 1, 1, "employee@example.com", new DateTime(2025, 12, 4, 22, 4, 56, 605, DateTimeKind.Utc).AddTicks(3339), "employee", "555-555", 1, "employee", 2 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "AirlineId", "Model", "TotalSeats" },
                values: new object[,]
                {
                    { 1, 1, "Boeing 737", 180 },
                    { 2, 2, "Airbus A320", 160 },
                    { 3, 3, "Boeing 777", 300 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "AirplaneId", "SeatClassId", "SeatNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, "1A" },
                    { 2, 1, 1, "1B" },
                    { 3, 1, 1, "1C" },
                    { 4, 1, 1, "1D" },
                    { 5, 1, 1, "1E" },
                    { 6, 1, 1, "1F" },
                    { 7, 1, 1, "2A" },
                    { 8, 1, 1, "2B" },
                    { 9, 1, 1, "2C" },
                    { 10, 1, 1, "2D" },
                    { 11, 1, 1, "2E" },
                    { 12, 1, 1, "2F" },
                    { 13, 1, 1, "3A" },
                    { 14, 1, 1, "3B" },
                    { 15, 1, 1, "3C" },
                    { 16, 1, 1, "3D" },
                    { 17, 1, 1, "3E" },
                    { 18, 1, 1, "3F" },
                    { 19, 1, 1, "4A" },
                    { 20, 1, 1, "4B" },
                    { 21, 1, 1, "4C" },
                    { 22, 1, 1, "4D" },
                    { 23, 1, 1, "4E" },
                    { 24, 1, 1, "4F" },
                    { 25, 1, 1, "5A" },
                    { 26, 1, 1, "5B" },
                    { 27, 1, 1, "5C" },
                    { 28, 1, 1, "5D" },
                    { 29, 1, 1, "5E" },
                    { 30, 1, 1, "5F" },
                    { 31, 1, 1, "6A" },
                    { 32, 1, 1, "6B" },
                    { 33, 1, 1, "6C" },
                    { 34, 1, 1, "6D" },
                    { 35, 1, 1, "6E" },
                    { 36, 1, 1, "6F" },
                    { 37, 1, 1, "7A" },
                    { 38, 1, 1, "7B" },
                    { 39, 1, 1, "7C" },
                    { 40, 1, 1, "7D" },
                    { 41, 1, 1, "7E" },
                    { 42, 1, 1, "7F" },
                    { 43, 1, 1, "8A" },
                    { 44, 1, 1, "8B" },
                    { 45, 1, 1, "8C" },
                    { 46, 1, 1, "8D" },
                    { 47, 1, 1, "8E" },
                    { 48, 1, 1, "8F" },
                    { 49, 1, 1, "9A" },
                    { 50, 1, 1, "9B" },
                    { 51, 1, 1, "9C" },
                    { 52, 1, 1, "9D" },
                    { 53, 1, 1, "9E" },
                    { 54, 1, 1, "9F" },
                    { 55, 1, 1, "10A" },
                    { 56, 1, 1, "10B" },
                    { 57, 1, 1, "10C" },
                    { 58, 1, 1, "10D" },
                    { 59, 1, 1, "10E" },
                    { 60, 1, 1, "10F" },
                    { 61, 1, 1, "11A" },
                    { 62, 1, 1, "11B" },
                    { 63, 1, 1, "11C" },
                    { 64, 1, 1, "11D" },
                    { 65, 1, 1, "11E" },
                    { 66, 1, 1, "11F" },
                    { 67, 1, 1, "12A" },
                    { 68, 1, 1, "12B" },
                    { 69, 1, 1, "12C" },
                    { 70, 1, 1, "12D" },
                    { 71, 1, 1, "12E" },
                    { 72, 1, 1, "12F" },
                    { 73, 1, 1, "13A" },
                    { 74, 1, 1, "13B" },
                    { 75, 1, 1, "13C" },
                    { 76, 1, 1, "13D" },
                    { 77, 1, 1, "13E" },
                    { 78, 1, 1, "13F" },
                    { 79, 1, 1, "14A" },
                    { 80, 1, 1, "14B" },
                    { 81, 1, 1, "14C" },
                    { 82, 1, 1, "14D" },
                    { 83, 1, 1, "14E" },
                    { 84, 1, 1, "14F" },
                    { 85, 1, 1, "15A" },
                    { 86, 1, 1, "15B" },
                    { 87, 1, 1, "15C" },
                    { 88, 1, 1, "15D" },
                    { 89, 1, 1, "15E" },
                    { 90, 1, 1, "15F" },
                    { 91, 1, 1, "16A" },
                    { 92, 1, 1, "16B" },
                    { 93, 1, 1, "16C" },
                    { 94, 1, 1, "16D" },
                    { 95, 1, 1, "16E" },
                    { 96, 1, 1, "16F" },
                    { 97, 1, 1, "17A" },
                    { 98, 1, 1, "17B" },
                    { 99, 1, 1, "17C" },
                    { 100, 1, 1, "17D" },
                    { 101, 1, 1, "17E" },
                    { 102, 1, 1, "17F" },
                    { 103, 1, 1, "18A" },
                    { 104, 1, 1, "18B" },
                    { 105, 1, 1, "18C" },
                    { 106, 1, 1, "18D" },
                    { 107, 1, 1, "18E" },
                    { 108, 1, 1, "18F" },
                    { 109, 1, 1, "19A" },
                    { 110, 1, 1, "19B" },
                    { 111, 1, 1, "19C" },
                    { 112, 1, 1, "19D" },
                    { 113, 1, 1, "19E" },
                    { 114, 1, 1, "19F" },
                    { 115, 1, 1, "20A" },
                    { 116, 1, 1, "20B" },
                    { 117, 1, 1, "20C" },
                    { 118, 1, 1, "20D" },
                    { 119, 1, 1, "20E" },
                    { 120, 1, 1, "20F" },
                    { 121, 1, 1, "21A" },
                    { 122, 1, 1, "21B" },
                    { 123, 1, 1, "21C" },
                    { 124, 1, 1, "21D" },
                    { 125, 1, 1, "21E" },
                    { 126, 1, 1, "21F" },
                    { 127, 1, 1, "22A" },
                    { 128, 1, 1, "22B" },
                    { 129, 1, 1, "22C" },
                    { 130, 1, 1, "22D" },
                    { 131, 1, 1, "22E" },
                    { 132, 1, 1, "22F" },
                    { 133, 1, 1, "23A" },
                    { 134, 1, 1, "23B" },
                    { 135, 1, 1, "23C" },
                    { 136, 1, 1, "23D" },
                    { 137, 1, 1, "23E" },
                    { 138, 1, 1, "23F" },
                    { 139, 1, 1, "24A" },
                    { 140, 1, 1, "24B" },
                    { 141, 1, 1, "24C" },
                    { 142, 1, 1, "24D" },
                    { 143, 1, 1, "24E" },
                    { 144, 1, 1, "24F" },
                    { 145, 1, 1, "25A" },
                    { 146, 1, 1, "25B" },
                    { 147, 1, 1, "25C" },
                    { 148, 1, 1, "25D" },
                    { 149, 1, 1, "25E" },
                    { 150, 1, 1, "25F" },
                    { 151, 1, 1, "26A" },
                    { 152, 1, 1, "26B" },
                    { 153, 1, 1, "26C" },
                    { 154, 1, 1, "26D" },
                    { 155, 1, 1, "26E" },
                    { 156, 1, 1, "26F" },
                    { 157, 1, 1, "27A" },
                    { 158, 1, 1, "27B" },
                    { 159, 1, 1, "27C" },
                    { 160, 1, 1, "27D" },
                    { 161, 1, 1, "27E" },
                    { 162, 1, 1, "27F" },
                    { 163, 1, 1, "28A" },
                    { 164, 1, 1, "28B" },
                    { 165, 1, 1, "28C" },
                    { 166, 1, 1, "28D" },
                    { 167, 1, 1, "28E" },
                    { 168, 1, 1, "28F" },
                    { 169, 1, 1, "29A" },
                    { 170, 1, 1, "29B" },
                    { 171, 1, 1, "29C" },
                    { 172, 1, 1, "29D" },
                    { 173, 1, 1, "29E" },
                    { 174, 1, 1, "29F" },
                    { 175, 1, 1, "30A" },
                    { 176, 1, 1, "30B" },
                    { 177, 1, 1, "30C" },
                    { 178, 1, 1, "30D" },
                    { 179, 1, 1, "30E" },
                    { 180, 1, 1, "30F" },
                    { 181, 2, 1, "1A" },
                    { 182, 2, 1, "1B" },
                    { 183, 2, 1, "1C" },
                    { 184, 2, 1, "1D" },
                    { 185, 2, 1, "1E" },
                    { 186, 2, 1, "1F" },
                    { 187, 2, 1, "2A" },
                    { 188, 2, 1, "2B" },
                    { 189, 2, 1, "2C" },
                    { 190, 2, 1, "2D" },
                    { 191, 2, 1, "2E" },
                    { 192, 2, 1, "2F" },
                    { 193, 2, 1, "3A" },
                    { 194, 2, 1, "3B" },
                    { 195, 2, 1, "3C" },
                    { 196, 2, 1, "3D" },
                    { 197, 2, 1, "3E" },
                    { 198, 2, 1, "3F" },
                    { 199, 2, 1, "4A" },
                    { 200, 2, 1, "4B" },
                    { 201, 2, 1, "4C" },
                    { 202, 2, 1, "4D" },
                    { 203, 2, 1, "4E" },
                    { 204, 2, 1, "4F" },
                    { 205, 2, 1, "5A" },
                    { 206, 2, 1, "5B" },
                    { 207, 2, 1, "5C" },
                    { 208, 2, 1, "5D" },
                    { 209, 2, 1, "5E" },
                    { 210, 2, 1, "5F" },
                    { 211, 2, 1, "6A" },
                    { 212, 2, 1, "6B" },
                    { 213, 2, 1, "6C" },
                    { 214, 2, 1, "6D" },
                    { 215, 2, 1, "6E" },
                    { 216, 2, 1, "6F" },
                    { 217, 2, 1, "7A" },
                    { 218, 2, 1, "7B" },
                    { 219, 2, 1, "7C" },
                    { 220, 2, 1, "7D" },
                    { 221, 2, 1, "7E" },
                    { 222, 2, 1, "7F" },
                    { 223, 2, 1, "8A" },
                    { 224, 2, 1, "8B" },
                    { 225, 2, 1, "8C" },
                    { 226, 2, 1, "8D" },
                    { 227, 2, 1, "8E" },
                    { 228, 2, 1, "8F" },
                    { 229, 2, 1, "9A" },
                    { 230, 2, 1, "9B" },
                    { 231, 2, 1, "9C" },
                    { 232, 2, 1, "9D" },
                    { 233, 2, 1, "9E" },
                    { 234, 2, 1, "9F" },
                    { 235, 2, 1, "10A" },
                    { 236, 2, 1, "10B" },
                    { 237, 2, 1, "10C" },
                    { 238, 2, 1, "10D" },
                    { 239, 2, 1, "10E" },
                    { 240, 2, 1, "10F" },
                    { 241, 2, 1, "11A" },
                    { 242, 2, 1, "11B" },
                    { 243, 2, 1, "11C" },
                    { 244, 2, 1, "11D" },
                    { 245, 2, 1, "11E" },
                    { 246, 2, 1, "11F" },
                    { 247, 2, 1, "12A" },
                    { 248, 2, 1, "12B" },
                    { 249, 2, 1, "12C" },
                    { 250, 2, 1, "12D" },
                    { 251, 2, 1, "12E" },
                    { 252, 2, 1, "12F" },
                    { 253, 2, 1, "13A" },
                    { 254, 2, 1, "13B" },
                    { 255, 2, 1, "13C" },
                    { 256, 2, 1, "13D" },
                    { 257, 2, 1, "13E" },
                    { 258, 2, 1, "13F" },
                    { 259, 2, 1, "14A" },
                    { 260, 2, 1, "14B" },
                    { 261, 2, 1, "14C" },
                    { 262, 2, 1, "14D" },
                    { 263, 2, 1, "14E" },
                    { 264, 2, 1, "14F" },
                    { 265, 2, 1, "15A" },
                    { 266, 2, 1, "15B" },
                    { 267, 2, 1, "15C" },
                    { 268, 2, 1, "15D" },
                    { 269, 2, 1, "15E" },
                    { 270, 2, 1, "15F" },
                    { 271, 2, 1, "16A" },
                    { 272, 2, 1, "16B" },
                    { 273, 2, 1, "16C" },
                    { 274, 2, 1, "16D" },
                    { 275, 2, 1, "16E" },
                    { 276, 2, 1, "16F" },
                    { 277, 2, 1, "17A" },
                    { 278, 2, 1, "17B" },
                    { 279, 2, 1, "17C" },
                    { 280, 2, 1, "17D" },
                    { 281, 2, 1, "17E" },
                    { 282, 2, 1, "17F" },
                    { 283, 2, 1, "18A" },
                    { 284, 2, 1, "18B" },
                    { 285, 2, 1, "18C" },
                    { 286, 2, 1, "18D" },
                    { 287, 2, 1, "18E" },
                    { 288, 2, 1, "18F" },
                    { 289, 2, 1, "19A" },
                    { 290, 2, 1, "19B" },
                    { 291, 2, 1, "19C" },
                    { 292, 2, 1, "19D" },
                    { 293, 2, 1, "19E" },
                    { 294, 2, 1, "19F" },
                    { 295, 2, 1, "20A" },
                    { 296, 2, 1, "20B" },
                    { 297, 2, 1, "20C" },
                    { 298, 2, 1, "20D" },
                    { 299, 2, 1, "20E" },
                    { 300, 2, 1, "20F" },
                    { 301, 2, 1, "21A" },
                    { 302, 2, 1, "21B" },
                    { 303, 2, 1, "21C" },
                    { 304, 2, 1, "21D" },
                    { 305, 2, 1, "21E" },
                    { 306, 2, 1, "21F" },
                    { 307, 2, 1, "22A" },
                    { 308, 2, 1, "22B" },
                    { 309, 2, 1, "22C" },
                    { 310, 2, 1, "22D" },
                    { 311, 2, 1, "22E" },
                    { 312, 2, 1, "22F" },
                    { 313, 2, 1, "23A" },
                    { 314, 2, 1, "23B" },
                    { 315, 2, 1, "23C" },
                    { 316, 2, 1, "23D" },
                    { 317, 2, 1, "23E" },
                    { 318, 2, 1, "23F" },
                    { 319, 2, 1, "24A" },
                    { 320, 2, 1, "24B" },
                    { 321, 2, 1, "24C" },
                    { 322, 2, 1, "24D" },
                    { 323, 2, 1, "24E" },
                    { 324, 2, 1, "24F" },
                    { 325, 2, 1, "25A" },
                    { 326, 2, 1, "25B" },
                    { 327, 2, 1, "25C" },
                    { 328, 2, 1, "25D" },
                    { 329, 2, 1, "25E" },
                    { 330, 2, 1, "25F" },
                    { 331, 2, 1, "26A" },
                    { 332, 2, 1, "26B" },
                    { 333, 2, 1, "26C" },
                    { 334, 2, 1, "26D" },
                    { 335, 2, 1, "26E" },
                    { 336, 2, 1, "26F" },
                    { 337, 2, 1, "27A" },
                    { 338, 2, 1, "27B" },
                    { 339, 2, 1, "27C" },
                    { 340, 2, 1, "27D" },
                    { 341, 2, 1, "27E" },
                    { 342, 2, 1, "27F" },
                    { 343, 2, 1, "28A" },
                    { 344, 2, 1, "28B" },
                    { 345, 2, 1, "28C" },
                    { 346, 2, 1, "28D" },
                    { 347, 2, 1, "28E" },
                    { 348, 2, 1, "28F" },
                    { 349, 2, 1, "29A" },
                    { 350, 2, 1, "29B" },
                    { 351, 2, 1, "29C" },
                    { 352, 2, 1, "29D" },
                    { 353, 2, 1, "29E" },
                    { 354, 2, 1, "29F" },
                    { 355, 2, 1, "30A" },
                    { 356, 2, 1, "30B" },
                    { 357, 2, 1, "30C" },
                    { 358, 2, 1, "30D" },
                    { 359, 2, 1, "30E" },
                    { 360, 2, 1, "30F" },
                    { 361, 3, 1, "1A" },
                    { 362, 3, 1, "1B" },
                    { 363, 3, 1, "1C" },
                    { 364, 3, 1, "1D" },
                    { 365, 3, 1, "1E" },
                    { 366, 3, 1, "1F" },
                    { 367, 3, 1, "2A" },
                    { 368, 3, 1, "2B" },
                    { 369, 3, 1, "2C" },
                    { 370, 3, 1, "2D" },
                    { 371, 3, 1, "2E" },
                    { 372, 3, 1, "2F" },
                    { 373, 3, 1, "3A" },
                    { 374, 3, 1, "3B" },
                    { 375, 3, 1, "3C" },
                    { 376, 3, 1, "3D" },
                    { 377, 3, 1, "3E" },
                    { 378, 3, 1, "3F" },
                    { 379, 3, 1, "4A" },
                    { 380, 3, 1, "4B" },
                    { 381, 3, 1, "4C" },
                    { 382, 3, 1, "4D" },
                    { 383, 3, 1, "4E" },
                    { 384, 3, 1, "4F" },
                    { 385, 3, 1, "5A" },
                    { 386, 3, 1, "5B" },
                    { 387, 3, 1, "5C" },
                    { 388, 3, 1, "5D" },
                    { 389, 3, 1, "5E" },
                    { 390, 3, 1, "5F" },
                    { 391, 3, 1, "6A" },
                    { 392, 3, 1, "6B" },
                    { 393, 3, 1, "6C" },
                    { 394, 3, 1, "6D" },
                    { 395, 3, 1, "6E" },
                    { 396, 3, 1, "6F" },
                    { 397, 3, 1, "7A" },
                    { 398, 3, 1, "7B" },
                    { 399, 3, 1, "7C" },
                    { 400, 3, 1, "7D" },
                    { 401, 3, 1, "7E" },
                    { 402, 3, 1, "7F" },
                    { 403, 3, 1, "8A" },
                    { 404, 3, 1, "8B" },
                    { 405, 3, 1, "8C" },
                    { 406, 3, 1, "8D" },
                    { 407, 3, 1, "8E" },
                    { 408, 3, 1, "8F" },
                    { 409, 3, 1, "9A" },
                    { 410, 3, 1, "9B" },
                    { 411, 3, 1, "9C" },
                    { 412, 3, 1, "9D" },
                    { 413, 3, 1, "9E" },
                    { 414, 3, 1, "9F" },
                    { 415, 3, 1, "10A" },
                    { 416, 3, 1, "10B" },
                    { 417, 3, 1, "10C" },
                    { 418, 3, 1, "10D" },
                    { 419, 3, 1, "10E" },
                    { 420, 3, 1, "10F" },
                    { 421, 3, 1, "11A" },
                    { 422, 3, 1, "11B" },
                    { 423, 3, 1, "11C" },
                    { 424, 3, 1, "11D" },
                    { 425, 3, 1, "11E" },
                    { 426, 3, 1, "11F" },
                    { 427, 3, 1, "12A" },
                    { 428, 3, 1, "12B" },
                    { 429, 3, 1, "12C" },
                    { 430, 3, 1, "12D" },
                    { 431, 3, 1, "12E" },
                    { 432, 3, 1, "12F" },
                    { 433, 3, 1, "13A" },
                    { 434, 3, 1, "13B" },
                    { 435, 3, 1, "13C" },
                    { 436, 3, 1, "13D" },
                    { 437, 3, 1, "13E" },
                    { 438, 3, 1, "13F" },
                    { 439, 3, 1, "14A" },
                    { 440, 3, 1, "14B" },
                    { 441, 3, 1, "14C" },
                    { 442, 3, 1, "14D" },
                    { 443, 3, 1, "14E" },
                    { 444, 3, 1, "14F" },
                    { 445, 3, 1, "15A" },
                    { 446, 3, 1, "15B" },
                    { 447, 3, 1, "15C" },
                    { 448, 3, 1, "15D" },
                    { 449, 3, 1, "15E" },
                    { 450, 3, 1, "15F" },
                    { 451, 3, 1, "16A" },
                    { 452, 3, 1, "16B" },
                    { 453, 3, 1, "16C" },
                    { 454, 3, 1, "16D" },
                    { 455, 3, 1, "16E" },
                    { 456, 3, 1, "16F" },
                    { 457, 3, 1, "17A" },
                    { 458, 3, 1, "17B" },
                    { 459, 3, 1, "17C" },
                    { 460, 3, 1, "17D" },
                    { 461, 3, 1, "17E" },
                    { 462, 3, 1, "17F" },
                    { 463, 3, 1, "18A" },
                    { 464, 3, 1, "18B" },
                    { 465, 3, 1, "18C" },
                    { 466, 3, 1, "18D" },
                    { 467, 3, 1, "18E" },
                    { 468, 3, 1, "18F" },
                    { 469, 3, 1, "19A" },
                    { 470, 3, 1, "19B" },
                    { 471, 3, 1, "19C" },
                    { 472, 3, 1, "19D" },
                    { 473, 3, 1, "19E" },
                    { 474, 3, 1, "19F" },
                    { 475, 3, 1, "20A" },
                    { 476, 3, 1, "20B" },
                    { 477, 3, 1, "20C" },
                    { 478, 3, 1, "20D" },
                    { 479, 3, 1, "20E" },
                    { 480, 3, 1, "20F" },
                    { 481, 3, 1, "21A" },
                    { 482, 3, 1, "21B" },
                    { 483, 3, 1, "21C" },
                    { 484, 3, 1, "21D" },
                    { 485, 3, 1, "21E" },
                    { 486, 3, 1, "21F" },
                    { 487, 3, 1, "22A" },
                    { 488, 3, 1, "22B" },
                    { 489, 3, 1, "22C" },
                    { 490, 3, 1, "22D" },
                    { 491, 3, 1, "22E" },
                    { 492, 3, 1, "22F" },
                    { 493, 3, 1, "23A" },
                    { 494, 3, 1, "23B" },
                    { 495, 3, 1, "23C" },
                    { 496, 3, 1, "23D" },
                    { 497, 3, 1, "23E" },
                    { 498, 3, 1, "23F" },
                    { 499, 3, 1, "24A" },
                    { 500, 3, 1, "24B" },
                    { 501, 3, 1, "24C" },
                    { 502, 3, 1, "24D" },
                    { 503, 3, 1, "24E" },
                    { 504, 3, 1, "24F" },
                    { 505, 3, 1, "25A" },
                    { 506, 3, 1, "25B" },
                    { 507, 3, 1, "25C" },
                    { 508, 3, 1, "25D" },
                    { 509, 3, 1, "25E" },
                    { 510, 3, 1, "25F" },
                    { 511, 3, 1, "26A" },
                    { 512, 3, 1, "26B" },
                    { 513, 3, 1, "26C" },
                    { 514, 3, 1, "26D" },
                    { 515, 3, 1, "26E" },
                    { 516, 3, 1, "26F" },
                    { 517, 3, 1, "27A" },
                    { 518, 3, 1, "27B" },
                    { 519, 3, 1, "27C" },
                    { 520, 3, 1, "27D" },
                    { 521, 3, 1, "27E" },
                    { 522, 3, 1, "27F" },
                    { 523, 3, 1, "28A" },
                    { 524, 3, 1, "28B" },
                    { 525, 3, 1, "28C" },
                    { 526, 3, 1, "28D" },
                    { 527, 3, 1, "28E" },
                    { 528, 3, 1, "28F" },
                    { 529, 3, 1, "29A" },
                    { 530, 3, 1, "29B" },
                    { 531, 3, 1, "29C" },
                    { 532, 3, 1, "29D" },
                    { 533, 3, 1, "29E" },
                    { 534, 3, 1, "29F" },
                    { 535, 3, 1, "30A" },
                    { 536, 3, 1, "30B" },
                    { 537, 3, 1, "30C" },
                    { 538, 3, 1, "30D" },
                    { 539, 3, 1, "30E" },
                    { 540, 3, 1, "30F" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeatClasses",
                keyColumn: "SeatClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeatClasses",
                keyColumn: "SeatClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeatClasses",
                keyColumn: "SeatClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "AirlineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportId",
                keyValue: 2);
        }
    }
}
