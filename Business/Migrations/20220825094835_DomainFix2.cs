using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Business.Migrations
{
    public partial class DomainFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Directorates__DirectoratesId",
                table: "DirectoratePerson");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Persons__PeoplePersonId",
                table: "DirectoratePerson");

            migrationBuilder.RenameColumn(
                name: "_PeoplePersonId",
                table: "DirectoratePerson",
                newName: "PeoplePersonId");

            migrationBuilder.RenameColumn(
                name: "_DirectoratesId",
                table: "DirectoratePerson",
                newName: "DirectoratesId");

            migrationBuilder.RenameIndex(
                name: "IX_DirectoratePerson__PeoplePersonId",
                table: "DirectoratePerson",
                newName: "IX_DirectoratePerson_PeoplePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Directorates_DirectoratesId",
                table: "DirectoratePerson",
                column: "DirectoratesId",
                principalTable: "Directorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Persons_PeoplePersonId",
                table: "DirectoratePerson",
                column: "PeoplePersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Directorates_DirectoratesId",
                table: "DirectoratePerson");

            migrationBuilder.DropForeignKey(
                name: "FK_DirectoratePerson_Persons_PeoplePersonId",
                table: "DirectoratePerson");

            migrationBuilder.RenameColumn(
                name: "PeoplePersonId",
                table: "DirectoratePerson",
                newName: "_PeoplePersonId");

            migrationBuilder.RenameColumn(
                name: "DirectoratesId",
                table: "DirectoratePerson",
                newName: "_DirectoratesId");

            migrationBuilder.RenameIndex(
                name: "IX_DirectoratePerson_PeoplePersonId",
                table: "DirectoratePerson",
                newName: "IX_DirectoratePerson__PeoplePersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Directorates__DirectoratesId",
                table: "DirectoratePerson",
                column: "_DirectoratesId",
                principalTable: "Directorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectoratePerson_Persons__PeoplePersonId",
                table: "DirectoratePerson",
                column: "_PeoplePersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
