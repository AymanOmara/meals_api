using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class GetIngredientRecipeDto
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public GetIngredientDto? Ingredient { get; set; }

        [Required]
        public decimal IngredientCountInGM { get; set; }
    }
}

