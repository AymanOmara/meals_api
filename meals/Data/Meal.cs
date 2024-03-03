using System.ComponentModel.DataAnnotations;

namespace meals.Data
{
	public class Meal
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		//[Required]
		//public Recipe Recipe { get; set; } = null!;

	}
}

