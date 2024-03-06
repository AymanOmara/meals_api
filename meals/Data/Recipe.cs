using System.ComponentModel.DataAnnotations;

namespace meals.Data
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<IngredientRecipe>? IngredientRecipes { get; set; }
        
    }
}

