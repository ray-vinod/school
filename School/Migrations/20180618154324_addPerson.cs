using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class addPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Persons");

            migrationBuilder.AlterColumn<int>(
                name: "serviceType",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "position",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "RegistrationNo",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RollNo",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RegistrationNo",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RollNo",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Teachers");

            migrationBuilder.AlterColumn<int>(
                name: "serviceType",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "position",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    RegistrationNo = table.Column<Guid>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    FName = table.Column<string>(maxLength: 100, nullable: false),
                    LName = table.Column<string>(maxLength: 100, nullable: false),
                    MName = table.Column<string>(maxLength: 100, nullable: true),
                    RollNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.RegistrationNo);
                });
        }
    }
}
