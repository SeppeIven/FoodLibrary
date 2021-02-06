using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TodoApi.Migrations
{
    public partial class AddIngredientTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dishIngredientRelations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dishID = table.Column<int>(type: "integer", nullable: true),
                    ingredientID = table.Column<int>(type: "integer", nullable: true),
                    AmountPerPerson = table.Column<int>(type: "integer", nullable: false),
                    UnitType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishIngredientRelations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_dishIngredientRelations_Dishes_dishID",
                        column: x => x.dishID,
                        principalTable: "Dishes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dishIngredientRelations_Ingredients_ingredientID",
                        column: x => x.ingredientID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dishIngredientRelations_dishID",
                table: "dishIngredientRelations",
                column: "dishID");

            migrationBuilder.CreateIndex(
                name: "IX_dishIngredientRelations_ingredientID",
                table: "dishIngredientRelations",
                column: "ingredientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dishIngredientRelations");
        }
    }
}
