using System.ComponentModel.DataAnnotations;

namespace meals.Data
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public String Name { get; set; } = null!;

		[Required]
		public String ImagUrl { get; set; } = null!;

		public List<Meal> Meals { get; set; } = new List<Meal>(){};
    }
}

