using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class contactRlation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Contacts_ContactId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ContactId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "Teacher_AddressId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_ContactId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Addresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_StudentId",
                table: "Contacts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StudentId",
                table: "Addresses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TeacherId",
                table: "Addresses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Persons_StudentId",
                table: "Addresses",
                column: "StudentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Persons_TeacherId",
                table: "Addresses",
                column: "TeacherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Persons_StudentId",
                table: "Contacts",
                column: "StudentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Persons_TeacherId",
                table: "Contacts",
                column: "TeacherId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Persons_StudentId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Persons_TeacherId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Persons_StudentId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Persons_TeacherId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_StudentId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StudentId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_TeacherId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Teacher_AddressId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Teacher_ContactId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId",
                unique: true,
                filter: "[AddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ContactId",
                table: "Persons",
                column: "ContactId",
                unique: true,
                filter: "[ContactId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Contacts_ContactId",
                table: "Persons",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
