using AutoMapper;
using meals.Data;
using meals.Dto;

namespace meals.Profiles
{
	public class CategoryProfile: Profile
    {
		public CategoryProfile()
		{
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<WriteOnlyCategoryDto, Category>();
        }
	}
}

