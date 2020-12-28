using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarage.Migrations
{
    public partial class LaborAndPartsCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Upgrades",
                newName: "PartsCost");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Repairs",
                newName: "PartsCost");

            migrationBuilder.AddColumn<decimal>(
                name: "LaborCost",
                table: "Upgrades",
                type: "decimal(8,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LaborCost",
                table: "Repairs",
                type: "decimal(8,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaborCost",
                table: "Upgrades");

            migrationBuilder.DropColumn(
                name: "LaborCost",
                table: "Repairs");

            migrationBuilder.RenameColumn(
                name: "PartsCost",
                table: "Upgrades",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "PartsCost",
                table: "Repairs",
                newName: "Cost");
        }
    }
}
