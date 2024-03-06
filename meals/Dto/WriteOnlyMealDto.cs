using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class WriteOnlyMealDto
	{
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int RecipeId { get; set; }

        [Required]
        public int CategoryId { get; set; }

    }
}

