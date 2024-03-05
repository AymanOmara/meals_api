using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class AddIngredientRecipeDto
	{
        [Required]
        public int Id { get; set; }

        [Required]
        public decimal IngredientCountInGM { get; set; }
    }
}

