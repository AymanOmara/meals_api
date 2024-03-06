using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace meals.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMealTableRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_CategoryId",
                table: "Meals");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meals_MealId",
                table: "Meals",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_MealId",
                table: "Meals",
                column: "MealId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_MealId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_MealId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Meals");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CategoryId",
                table: "Meals",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
