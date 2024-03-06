using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
    public class IngredientRecipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Ingredient")]
        public int? IngredientId { get; set; }

        [ForeignKey("RecipeId")]
        public int? RecipeId { get; set; }

        [Required]
        public decimal IngredientCountInGM { get; set; }

        public Ingredient? Ingredient { set; get; }

        public Recipe? Recipe { set; get; }


    }
}

