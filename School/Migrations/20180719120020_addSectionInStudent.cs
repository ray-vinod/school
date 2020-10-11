using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class addSectionInStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grades",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Temporary",
                table: "Addresses",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Permanent",
                table: "Addresses",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "StudentViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RollNo = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SectionId",
                table: "Persons",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Sections_SectionId",
                table: "Persons",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Sections_SectionId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "StudentViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SectionId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Persons");

            migrationBuilder.AlterColumn<string>(
                name: "GradeName",
                table: "Grades",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Temporary",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Permanent",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
