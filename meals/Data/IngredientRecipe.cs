using System.ComponentModel.DataAnnotations;

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

		public Recipe? Recipe { get; set; }

	}
}

