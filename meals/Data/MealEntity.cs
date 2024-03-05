using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

		[JsonIgnore]
		[ForeignKey("CategoryId")]
		public Category Category { get; set; } = null!;

        [Required]
		public required Recipe Recipe { get; set; } = null!;

	}
}

