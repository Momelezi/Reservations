using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class DataPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Education & Planning");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Curriculum & Assessment Management");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Active", "Description" },
                values: new object[,]
                {
                    { 3, true, "Institutional Development" },
                    { 4, true, "Corporate Services" }
                });

            migrationBuilder.InsertData(
                table: "TargetAudiences",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Foundation Phase Teachers" },
                    { 2, true, "Circuit Principals" },
                    { 3, true, "Subject Advisor" }
                });

            migrationBuilder.InsertData(
                table: "VenueCategorys",
                columns: new[] { "Id", "Active", "Descr" },
                values: new object[,]
                {
                    { 1, true, "Auditorium" },
                    { 2, true, "Lecture Room" },
                    { 3, true, "Computer Lab" },
                    { 4, true, "Boardroom" },
                    { 5, true, "Meeting Room" },
                    { 6, true, "Theater" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TargetAudiences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VenueCategorys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Computer Science");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Chemistry");
        }
    }
}
