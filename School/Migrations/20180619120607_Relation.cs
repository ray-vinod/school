using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Sections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_GradeId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_GradeId",
                table: "Sections",
                column: "GradeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GradeId",
                table: "Persons",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Teacher_GradeId",
                table: "Persons",
                column: "Teacher_GradeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Grades_GradeId",
                table: "Persons",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Grades_Teacher_GradeId",
                table: "Persons",
                column: "Teacher_GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Grades_GradeId",
                table: "Sections",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Addresses_AddressId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Contacts_ContactId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Grades_GradeId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Grades_Teacher_GradeId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Grades_GradeId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_GradeId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ContactId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_GradeId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_Teacher_GradeId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Teacher_GradeId",
                table: "Persons");
        }
    }
}
