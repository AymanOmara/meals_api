using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace meals.Migrations
{
    /// <inheritdoc />
    public partial class AddRecipies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipe_Ingredients_IngredientId",
                table: "IngredientRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipe_Recipe_RecipeId",
                table: "IngredientRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Meals_MealId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientRecipe",
                table: "IngredientRecipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameTable(
                name: "IngredientRecipe",
                newName: "IngredientRecipes");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_MealId",
                table: "Recipes",
                newName: "IX_Recipes_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipe_RecipeId",
                table: "IngredientRecipes",
                newName: "IX_IngredientRecipes_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipe_IngredientId",
                table: "IngredientRecipes",
                newName: "IX_IngredientRecipes_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientRecipes",
                table: "IngredientRecipes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipes_Ingredients_IngredientId",
                table: "IngredientRecipes",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Meals_MealId",
                table: "Recipes",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipes_Ingredients_IngredientId",
                table: "IngredientRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Meals_MealId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientRecipes",
                table: "IngredientRecipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameTable(
                name: "IngredientRecipes",
                newName: "IngredientRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_MealId",
                table: "Recipe",
                newName: "IX_Recipe_MealId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipes_RecipeId",
                table: "IngredientRecipe",
                newName: "IX_IngredientRecipe_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipes_IngredientId",
                table: "IngredientRecipe",
                newName: "IX_IngredientRecipe_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientRecipe",
                table: "IngredientRecipe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipe_Ingredients_IngredientId",
                table: "IngredientRecipe",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipe_Recipe_RecipeId",
                table: "IngredientRecipe",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Meals_MealId",
                table: "Recipe",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id");
        }
    }
}
