using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace meals.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToMealTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meal_Categories_CategoryId",
                table: "Meal");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Meal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Meal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipe_Meal_MealId",
                        column: x => x.MealId,
                        principalTable: "Meal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    IngredientCountInGM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_IngredientId",
                table: "IngredientRecipe",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipeId",
                table: "IngredientRecipe",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_MealId",
                table: "Recipe",
                column: "MealId",
                unique: true,
                filter: "[MealId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Meal_Categories_CategoryId",
                table: "Meal",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meal_Categories_CategoryId",
                table: "Meal");

            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Meal");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Meal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Meal_Categories_CategoryId",
                table: "Meal",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
