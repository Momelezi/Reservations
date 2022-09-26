using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class DataPopulation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Directorates");

            migrationBuilder.RenameColumn(
                name: "Activity",
                table: "InterventionTypes",
                newName: "Active");

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Program Delivery" },
                    { 2, true, "TQI" },
                    { 3, true, "ICT Integration" }
                });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "SES" },
                    { 2, true, "CES" },
                    { 3, true, "DCES" }
                });

            migrationBuilder.InsertData(
                table: "Directorates",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Ass Mngmt" },
                    { 2, true, "GET" },
                    { 3, true, "FET" }
                });

            migrationBuilder.InsertData(
                table: "EquipmentCategorys",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Laptop Computer" },
                    { 2, true, "Data Projector" },
                    { 3, true, "Whiteboard" }
                });

            migrationBuilder.InsertData(
                table: "InterventionTypes",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Training" },
                    { 2, true, "Workshop" },
                    { 3, true, "Conference" },
                    { 4, true, "Seminar" },
                    { 5, true, "Meeting" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directorates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directorates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directorates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipmentCategorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipmentCategorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentCategorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InterventionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InterventionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InterventionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InterventionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InterventionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "InterventionTypes",
                newName: "Activity");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Directorates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
