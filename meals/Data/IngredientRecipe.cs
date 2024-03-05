using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
	public class IngredientRecipe
	{
		[Key]
		public int Id { get; set; }

        [Required]
        public Ingredient? Ingredient { get; set; }

		[Required]
		public decimal IngredientCountInGM { get; set; }

		[ForeignKey("RecipeId")]
		public Recipe? Recipe { get; set; }
	}
}

