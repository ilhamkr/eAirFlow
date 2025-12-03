using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAirFlow.Services.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    airline_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Airlines__A016BF8090CACD74", x => x.airline_id);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    airplane_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    total_seats = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Airplane__CECD2849B1B94DCA", x => x.airplane_id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    position_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Position__99A0E7A4DB79BFD1", x => x.position_id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__8AFACE1A4E9A155F", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "SeatClasses",
                columns: table => new
                {
                    seat_class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    price_multiplier = table.Column<decimal>(type: "decimal(3,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SeatClas__DC348A0F7232C36B", x => x.seat_class_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    password_hash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B9BE370F977AC3CB", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    flight_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departure_location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    arrival_location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    departure_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    arrival_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    airline_id = table.Column<int>(type: "int", nullable: true),
                    airplane_id = table.Column<int>(type: "int", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Flights__E3705765AA48850A", x => x.flight_id);
                    table.ForeignKey(
                        name: "FK_Flights_Airlines",
                        column: x => x.airline_id,
                        principalTable: "Airlines",
                        principalColumn: "airline_id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    hire_date = table.Column<DateOnly>(type: "date", nullable: true),
                    position_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__C52E0BA830E8EBD2", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK_Employees_Position",
                        column: x => x.position_id,
                        principalTable: "Positions",
                        principalColumn: "position_id");
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    seat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    airplane_id = table.Column<int>(type: "int", nullable: true),
                    seat_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    seat_class_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Seats__906DED9C5162B2D2", x => x.seat_id);
                    table.ForeignKey(
                        name: "FK_Seats_Airplanes",
                        column: x => x.airplane_id,
                        principalTable: "Airplanes",
                        principalColumn: "airplane_id");
                    table.ForeignKey(
                        name: "FK_Seats_SeatClasses",
                        column: x => x.seat_class_id,
                        principalTable: "SeatClasses",
                        principalColumn: "seat_class_id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    notification_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sent_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__E059842F621D3789", x => x.notification_id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    payment_method = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    transaction_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    transaction_reference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__ED1FC9EAF4FBAC60", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK_Payments_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightReviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    submitted_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FlightRe__60883D90E9077F41", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                    table.ForeignKey(
                        name: "FK_Reviews_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Luggages",
                columns: table => new
                {
                    luggage_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    weight_kg = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    image_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Luggages__00F3B1704651ABD8", x => x.luggage_id);
                    table.ForeignKey(
                        name: "FK_Luggages_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                    table.ForeignKey(
                        name: "FK_Luggages_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAssignments",
                columns: table => new
                {
                    assignment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    job_role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    job_scope = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    assigned_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__DA891814BFC506B5", x => x.assignment_id);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_Assignments_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                });

            migrationBuilder.CreateTable(
                name: "FlightIssues",
                columns: table => new
                {
                    issue_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    reported_by = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    reported_at = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FlightIs__D6185C393F7EBB2B", x => x.issue_id);
                    table.ForeignKey(
                        name: "FK_Issues_Employees",
                        column: x => x.reported_by,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_Issues_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    flight_id = table.Column<int>(type: "int", nullable: true),
                    reservation_date = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    payment_id = table.Column<int>(type: "int", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reservat__31384C299B9BC2CB", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_Reservations_Flights",
                        column: x => x.flight_id,
                        principalTable: "Flights",
                        principalColumn: "flight_id");
                    table.ForeignKey(
                        name: "FK_Reservations_Payments",
                        column: x => x.payment_id,
                        principalTable: "Payments",
                        principalColumn: "payment_id");
                    table.ForeignKey(
                        name: "FK_Reservations_Users",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "LuggageReports",
                columns: table => new
                {
                    report_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    luggage_id = table.Column<int>(type: "int", nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    report_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    report_time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LuggageR__779B7C58AE1E15BE", x => x.report_id);
                    table.ForeignKey(
                        name: "FK_Reports_Employees",
                        column: x => x.employee_id,
                        principalTable: "Employees",
                        principalColumn: "employee_id");
                    table.ForeignKey(
                        name: "FK_Reports_Luggages",
                        column: x => x.luggage_id,
                        principalTable: "Luggages",
                        principalColumn: "luggage_id");
                });

            migrationBuilder.CreateTable(
                name: "CheckIns",
                columns: table => new
                {
                    checkin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reservation_id = table.Column<int>(type: "int", nullable: true),
                    seat_id = table.Column<int>(type: "int", nullable: true),
                    checkin_time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    StateMachine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CheckIns__234E2115E4228649", x => x.checkin_id);
                    table.ForeignKey(
                        name: "FK_CheckIns_Reservations",
                        column: x => x.reservation_id,
                        principalTable: "Reservations",
                        principalColumn: "reservation_id");
                    table.ForeignKey(
                        name: "FK_CheckIns_Seats",
                        column: x => x.seat_id,
                        principalTable: "Seats",
                        principalColumn: "seat_id");
                });

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
                name: "IX_CheckIns_reservation_id",
                table: "CheckIns",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_seat_id",
                table: "CheckIns",
                column: "seat_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_employee_id",
                table: "EmployeeAssignments",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAssignments_flight_id",
                table: "EmployeeAssignments",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_position_id",
                table: "Employees",
                column: "position_id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightIssues_flight_id",
                table: "FlightIssues",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightIssues_reported_by",
                table: "FlightIssues",
                column: "reported_by");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReviews_flight_id",
                table: "FlightReviews",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReviews_user_id",
                table: "FlightReviews",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_airline_id",
                table: "Flights",
                column: "airline_id");

            migrationBuilder.CreateIndex(
                name: "IX_LuggageReports_employee_id",
                table: "LuggageReports",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_LuggageReports_luggage_id",
                table: "LuggageReports",
                column: "luggage_id");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_flight_id",
                table: "Luggages",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_Luggages_user_id",
                table: "Luggages",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_user_id",
                table: "Notifications",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_user_id",
                table: "Payments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_flight_id",
                table: "Reservations",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_payment_id",
                table: "Reservations",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_user_id",
                table: "Reservations",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservations_seat_id",
                table: "SeatReservations",
                column: "seat_id");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_airplane_id",
                table: "Seats",
                column: "airplane_id");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_seat_class_id",
                table: "Seats",
                column: "seat_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__AB6E6164AA0B9A02",
                table: "Users",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckIns");

            migrationBuilder.DropTable(
                name: "EmployeeAssignments");

            migrationBuilder.DropTable(
                name: "FlightIssues");

            migrationBuilder.DropTable(
                name: "FlightReviews");

            migrationBuilder.DropTable(
                name: "LuggageReports");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "SeatReservations");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Luggages");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "SeatClasses");

            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
