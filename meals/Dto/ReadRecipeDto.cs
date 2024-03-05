using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class ReadRecipeDto
	{
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<GetIngredientRecipeDto> IngredientRecipes { get; set; }

        
    }
}

