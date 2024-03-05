using AutoMapper;
using meals.Data;
using meals.Dto;

namespace meals.Profiles
{
	public class MealProfile:Profile
	{
		public MealProfile()
		{
			CreateMap<MealEntity, MealDto>();
		}
	}
}

