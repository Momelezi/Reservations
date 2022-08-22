using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Active", "Description" },
                values: new object[] { 1, true, "Computer Science" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Active", "Description" },
                values: new object[] { 2, true, "Chemistry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2);
        }
    }
}
