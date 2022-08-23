using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class Domainfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Bookings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DirectoratePerson",
                columns: table => new
                {
                    _DirectoratesId = table.Column<int>(type: "int", nullable: false),
                    _PeoplePersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoratePerson", x => new { x._DirectoratesId, x._PeoplePersonId });
                    table.ForeignKey(
                        name: "FK_DirectoratePerson_Directorates__DirectoratesId",
                        column: x => x._DirectoratesId,
                        principalTable: "Directorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectoratePerson_Persons__PeoplePersonId",
                        column: x => x._PeoplePersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueCategoryId",
                table: "Venues",
                column: "VenueCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_VenueRoomId",
                table: "Venues",
                column: "VenueRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EquipmentCategoryId",
                table: "Equipments",
                column: "EquipmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ComponentId",
                table: "Bookings",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DesignationId",
                table: "Bookings",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DirectorateId",
                table: "Bookings",
                column: "DirectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PersonId",
                table: "Bookings",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectoratePerson__PeoplePersonId",
                table: "DirectoratePerson",
                column: "_PeoplePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Components_ComponentId",
                table: "Bookings",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "ComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Designations_DesignationId",
                table: "Bookings",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Directorates_DirectorateId",
                table: "Bookings",
                column: "DirectorateId",
                principalTable: "Directorates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Persons_PersonId",
                table: "Bookings",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipmentCategorys_EquipmentCategoryId",
                table: "Equipments",
                column: "EquipmentCategoryId",
                principalTable: "EquipmentCategorys",
                principalColumn: "EquipmentCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueCategorys_VenueCategoryId",
                table: "Venues",
                column: "VenueCategoryId",
                principalTable: "VenueCategorys",
                principalColumn: "VenueCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venues_VenueRooms_VenueRoomId",
                table: "Venues",
                column: "VenueRoomId",
                principalTable: "VenueRooms",
                principalColumn: "VenueRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Components_ComponentId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Designations_DesignationId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Directorates_DirectorateId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Persons_PersonId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipmentCategorys_EquipmentCategoryId",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueCategorys_VenueCategoryId",
                table: "Venues");

            migrationBuilder.DropForeignKey(
                name: "FK_Venues_VenueRooms_VenueRoomId",
                table: "Venues");

            migrationBuilder.DropTable(
                name: "DirectoratePerson");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueCategoryId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Venues_VenueRoomId",
                table: "Venues");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_EquipmentCategoryId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ComponentId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DesignationId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DirectorateId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PersonId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Bookings");
        }
    }
}
