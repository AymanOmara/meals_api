using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public List<IngredientRecipe> IngredientRecipes { get; set; } = new List<IngredientRecipe>() { };

        [ForeignKey("MealId")]
        public Meal? Meal { get; set; }
    }
}

