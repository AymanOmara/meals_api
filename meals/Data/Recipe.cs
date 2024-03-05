using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<IngredientRecipe> IngredientRecipes { get; set; }
        
        [ForeignKey("MealId")]
        public MealEntity? Meal { get; set; }
    }
}

