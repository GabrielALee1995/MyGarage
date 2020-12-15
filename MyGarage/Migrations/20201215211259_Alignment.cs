using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarage.Migrations
{
    public partial class Alignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Upgrades");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Repairs");

            migrationBuilder.AlterColumn<string>(
                name: "Receipt",
                table: "Upgrades",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Receipt",
                table: "Repairs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Receipt",
                table: "Upgrades",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Upgrades",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Receipt",
                table: "Repairs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Repairs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }
    }
}
