using AutoMapper;
using meals.Data;
using meals.Dto;

namespace meals.Profiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<AddRecipeDto, Recipe>();
            CreateMap<Recipe, ReadRecipeDto>();
        }
    }
}

