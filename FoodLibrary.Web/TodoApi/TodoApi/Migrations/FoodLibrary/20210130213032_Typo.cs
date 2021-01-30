using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations.FoodLibrary
{
    public partial class Typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreprationTimeMinutes",
                table: "Dishes",
                newName: "PreparationTimeMinutes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreparationTimeMinutes",
                table: "Dishes",
                newName: "PreprationTimeMinutes");
        }
    }
}
