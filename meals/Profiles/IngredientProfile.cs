using AutoMapper;
using meals.Data;
using meals.Dto;

namespace meals.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<IngredientUpdateOnly, Ingredient>();
        }
    }
}