using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class IngredientUpdateOnly
	{
		[Required]
		public int Id { get; set; }
        [Required]
		public string Name { get; set; } = null!;
	}
}

