using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class AddIngredientRecipeDto
	{
        [Required]
        public int IngredientId { set; get; }

        [Required]
        public decimal IngredientCountInGM { get; set; }
    }
}

