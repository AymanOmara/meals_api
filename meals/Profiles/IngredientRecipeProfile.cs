using AutoMapper;
using meals.Data;
using meals.Dto;

namespace meals.Profiles
{
	public class IngredientRecipeProfile:Profile
	{
		public IngredientRecipeProfile()
		{
			CreateMap<IngredientRecipe, GetIngredientRecipeDto>();
		}
	}
}

