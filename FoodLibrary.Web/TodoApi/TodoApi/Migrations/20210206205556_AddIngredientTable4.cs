using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.Migrations
{
    public partial class AddIngredientTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dishIngredientRelations_Dishes_dishID",
                table: "dishIngredientRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_dishIngredientRelations_Ingredients_ingredientID",
                table: "dishIngredientRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dishIngredientRelations",
                table: "dishIngredientRelations");

            migrationBuilder.RenameTable(
                name: "dishIngredientRelations",
                newName: "DishIngredientRelations");

            migrationBuilder.RenameIndex(
                name: "IX_dishIngredientRelations_ingredientID",
                table: "DishIngredientRelations",
                newName: "IX_DishIngredientRelations_ingredientID");

            migrationBuilder.RenameIndex(
                name: "IX_dishIngredientRelations_dishID",
                table: "DishIngredientRelations",
                newName: "IX_DishIngredientRelations_dishID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishIngredientRelations",
                table: "DishIngredientRelations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DishIngredientRelations_Dishes_dishID",
                table: "DishIngredientRelations",
                column: "dishID",
                principalTable: "Dishes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DishIngredientRelations_Ingredients_ingredientID",
                table: "DishIngredientRelations",
                column: "ingredientID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishIngredientRelations_Dishes_dishID",
                table: "DishIngredientRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_DishIngredientRelations_Ingredients_ingredientID",
                table: "DishIngredientRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishIngredientRelations",
                table: "DishIngredientRelations");

            migrationBuilder.RenameTable(
                name: "DishIngredientRelations",
                newName: "dishIngredientRelations");

            migrationBuilder.RenameIndex(
                name: "IX_DishIngredientRelations_ingredientID",
                table: "dishIngredientRelations",
                newName: "IX_dishIngredientRelations_ingredientID");

            migrationBuilder.RenameIndex(
                name: "IX_DishIngredientRelations_dishID",
                table: "dishIngredientRelations",
                newName: "IX_dishIngredientRelations_dishID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dishIngredientRelations",
                table: "dishIngredientRelations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_dishIngredientRelations_Dishes_dishID",
                table: "dishIngredientRelations",
                column: "dishID",
                principalTable: "Dishes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dishIngredientRelations_Ingredients_ingredientID",
                table: "dishIngredientRelations",
                column: "ingredientID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
