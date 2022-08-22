using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class mostofTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    ComponentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.ComponentId);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationId);
                });

            migrationBuilder.CreateTable(
                name: "Directorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorateId = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCategorys",
                columns: table => new
                {
                    EquipmentCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCategorys", x => x.EquipmentCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "InterventionTypes",
                columns: table => new
                {
                    InterventionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionTypes", x => x.InterventionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "TargetAudiences",
                columns: table => new
                {
                    TargetAudienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetAudiences", x => x.TargetAudienceId);
                });

            migrationBuilder.CreateTable(
                name: "VenueCategorys",
                columns: table => new
                {
                    VenueCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueCategorys", x => x.VenueCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "VenueRooms",
                columns: table => new
                {
                    VenueRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueRooms", x => x.VenueRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueCategoryId = table.Column<int>(type: "int", nullable: false),
                    VenueRoomId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PreparationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Requestor = table.Column<int>(type: "int", nullable: false),
                    ResponsiblePerson = table.Column<int>(type: "int", nullable: false),
                    ResponsibleDirector = table.Column<int>(type: "int", nullable: true),
                    UnitManager = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    DirectorateId = table.Column<int>(type: "int", nullable: true),
                    ComponentId = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentBookings",
                columns: table => new
                {
                    EquipmentBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentBookings", x => x.EquipmentBookingId);
                    table.ForeignKey(
                        name: "FK_EquipmentBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentBookings_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterventionTypeBookings",
                columns: table => new
                {
                    InterventionTypeBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterventionTypeId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionTypeBookings", x => x.InterventionTypeBookingId);
                    table.ForeignKey(
                        name: "FK_InterventionTypeBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterventionTypeBookings_InterventionTypes_InterventionTypeId",
                        column: x => x.InterventionTypeId,
                        principalTable: "InterventionTypes",
                        principalColumn: "InterventionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TargetAudienceBookings",
                columns: table => new
                {
                    TargetAudienceBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetAudienceId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetAudienceBookings", x => x.TargetAudienceBookingId);
                    table.ForeignKey(
                        name: "FK_TargetAudienceBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TargetAudienceBookings_TargetAudiences_TargetAudienceId",
                        column: x => x.TargetAudienceId,
                        principalTable: "TargetAudiences",
                        principalColumn: "TargetAudienceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenueBookings",
                columns: table => new
                {
                    VenueBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueBookings", x => x.VenueBookingId);
                    table.ForeignKey(
                        name: "FK_VenueBookings_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VenueBookings_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "VenueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BranchId",
                table: "Bookings",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentBookings_BookingId",
                table: "EquipmentBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentBookings_EquipmentId",
                table: "EquipmentBookings",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionTypeBookings_BookingId",
                table: "InterventionTypeBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionTypeBookings_InterventionTypeId",
                table: "InterventionTypeBookings",
                column: "InterventionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAudienceBookings_BookingId",
                table: "TargetAudienceBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAudienceBookings_TargetAudienceId",
                table: "TargetAudienceBookings",
                column: "TargetAudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueBookings_BookingId",
                table: "VenueBookings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueBookings_VenueId",
                table: "VenueBookings",
                column: "VenueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Directorates");

            migrationBuilder.DropTable(
                name: "EquipmentBookings");

            migrationBuilder.DropTable(
                name: "EquipmentCategorys");

            migrationBuilder.DropTable(
                name: "InterventionTypeBookings");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "TargetAudienceBookings");

            migrationBuilder.DropTable(
                name: "VenueBookings");

            migrationBuilder.DropTable(
                name: "VenueCategorys");

            migrationBuilder.DropTable(
                name: "VenueRooms");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "InterventionTypes");

            migrationBuilder.DropTable(
                name: "TargetAudiences");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }
    }
}
