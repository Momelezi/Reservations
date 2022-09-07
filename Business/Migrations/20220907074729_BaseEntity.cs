using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class BaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Persons_PeoplePersonId",
                table: "DirectoratePerson");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DirectorateId",
                table: "Directorates");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Venues",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VenueRoomId",
                table: "VenueRooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VenueCategoryId",
                table: "VenueCategorys",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VenueBookingId",
                table: "VenueBookings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TargetAudienceId",
                table: "TargetAudiences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TargetAudienceBookingId",
                table: "TargetAudienceBookings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Persons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InterventionTypeId",
                table: "InterventionTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InterventionTypeBookingId",
                table: "InterventionTypeBookings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "Equipments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EquipmentCategoryId",
                table: "EquipmentCategorys",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EquipmentBookingId",
                table: "EquipmentBookings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PeoplePersonId",
                table: "DirectoratePerson",
                newName: "PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_DirectoratePerson_PeoplePersonId",
                table: "DirectoratePerson",
                newName: "IX_DirectoratePerson_PeopleId");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "Designations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ComponentId",
                table: "Components",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Branches",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Persons_PeopleId",
                table: "DirectoratePerson",
                column: "PeopleId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Persons_PeopleId",
                table: "DirectoratePerson");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Venues",
                newName: "VenueId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VenueRooms",
                newName: "VenueRoomId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VenueCategorys",
                newName: "VenueCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VenueBookings",
                newName: "VenueBookingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TargetAudiences",
                newName: "TargetAudienceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TargetAudienceBookings",
                newName: "TargetAudienceBookingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persons",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InterventionTypes",
                newName: "InterventionTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InterventionTypeBookings",
                newName: "InterventionTypeBookingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipments",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EquipmentCategorys",
                newName: "EquipmentCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EquipmentBookings",
                newName: "EquipmentBookingId");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "DirectoratePerson",
                newName: "PeoplePersonId");

            migrationBuilder.RenameIndex(
                name: "IX_DirectoratePerson_PeopleId",
                table: "DirectoratePerson",
                newName: "IX_DirectoratePerson_PeoplePersonId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Designations",
                newName: "DesignationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Components",
                newName: "ComponentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "BookingId");

            migrationBuilder.AddColumn<int>(
                name: "DirectorateId",
                table: "Directorates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Active", "Description" },
                values: new object[] { 1, true, "Computer Science" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Active", "Description" },
                values: new object[] { 2, true, "Chemistry" });

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Persons_PeoplePersonId",
                table: "DirectoratePerson",
                column: "PeoplePersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
