using System.ComponentModel.DataAnnotations;

namespace meals.Data
{
	public class Ingredient
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

	}
}

