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

		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

        [Required]
		public Recipe Recipe { get; set; } = null!;

	}
}

