using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class Auditorium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VenueBookings_Venues_VenueId",
                table: "VenueBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueCategorys_VenueCategoryId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueRooms_VenueRoomId",
                table: "Venues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venues",
                table: "Venues");

            migrationBuilder.RenameTable(
                name: "Venues",
                newName: "Venue");

            migrationBuilder.RenameIndex(
                name: "IX_Venues_VenueRoomId",
                table: "Venue",
                newName: "IX_Venue_VenueRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Venues_VenueCategoryId",
                table: "Venue",
                newName: "IX_Venue_VenueCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AuditoriumRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriumRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditoriumRoom_VenueCategorys_VenueCategoryId",
                        column: x => x.VenueCategoryId,
                        principalTable: "VenueCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuditoriumRoom",
                columns: new[] { "Id", "Name", "VenueCategoryId" },
                values: new object[] { 1, "Auditorium 1", 1 });

            migrationBuilder.InsertData(
                table: "AuditoriumRoom",
                columns: new[] { "Id", "Name", "VenueCategoryId" },
                values: new object[] { 2, "Auditorium 2", 1 });

            migrationBuilder.InsertData(
                table: "AuditoriumRoom",
                columns: new[] { "Id", "Name", "VenueCategoryId" },
                values: new object[] { 3, "Auditorium 3", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriumRoom_VenueCategoryId",
                table: "AuditoriumRoom",
                column: "VenueCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venue_VenueCategorys_VenueCategoryId",
                table: "Venue",
                column: "VenueCategoryId",
                principalTable: "VenueCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venue_VenueRooms_VenueRoomId",
                table: "Venue",
                column: "VenueRoomId",
                principalTable: "VenueRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VenueBookings_Venue_VenueId",
                table: "VenueBookings",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venue_VenueCategorys_VenueCategoryId",
                table: "Venue");

            migrationBuilder.DropForeignKey(
                name: "FK_Venue_VenueRooms_VenueRoomId",
                table: "Venue");

            migrationBuilder.DropForeignKey(
                name: "FK_VenueBookings_Venue_VenueId",
                table: "VenueBookings");

            migrationBuilder.DropTable(
                name: "AuditoriumRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.RenameTable(
                name: "Venue",
                newName: "Venues");

            migrationBuilder.RenameIndex(
                name: "IX_Venue_VenueRoomId",
                table: "Venues",
                newName: "IX_Venues_VenueRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Venue_VenueCategoryId",
                table: "Venues",
                newName: "IX_Venues_VenueCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venues",
                table: "Venues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VenueBookings_Venues_VenueId",
                table: "VenueBookings",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueCategorys_VenueCategoryId",
                table: "Venues",
                column: "VenueCategoryId",
                principalTable: "VenueCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueRooms_VenueRoomId",
                table: "Venues",
                column: "VenueRoomId",
                principalTable: "VenueRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
