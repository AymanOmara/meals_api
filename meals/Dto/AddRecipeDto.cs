
using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class AddRecipeDto
	{
        [Required]
        public required string Name { get; set; }

        [Required]
        public required List<AddIngredientRecipeDto> IngredientRecipes { get; set; }

    }
}

