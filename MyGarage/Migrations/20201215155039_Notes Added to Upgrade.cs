using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarage.Migrations
{
    public partial class NotesAddedtoUpgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reciept",
                table: "Upgrades",
                newName: "Receipt");

            migrationBuilder.RenameColumn(
                name: "Reciept",
                table: "Repairs",
                newName: "Receipt");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Upgrades",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Repairs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Upgrades");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Repairs");

            migrationBuilder.RenameColumn(
                name: "Receipt",
                table: "Upgrades",
                newName: "Reciept");

            migrationBuilder.RenameColumn(
                name: "Receipt",
                table: "Repairs",
                newName: "Reciept");
        }
    }
}
