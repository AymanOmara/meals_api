using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace meals.Data
{
	public class Ingredient
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; } = null!;

		public bool Deleted { get; set; }

        [JsonIgnore]
		public List<IngredientRecipe>? IngredientRecips { get; set; }
	}
}

