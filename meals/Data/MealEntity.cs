using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
	public class MealEntity
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

		
		public Category? Category { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        
        public Recipe? Recipe { get; set; }

		[ForeignKey("RecipeId")]
        public int? RecipeId { get; set; }

    }
}

