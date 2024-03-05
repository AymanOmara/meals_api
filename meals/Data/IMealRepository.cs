using meals.Dto;

namespace meals.Data.Meal
{
	public interface IMealRepository
	{
		public List<MealEntity> GetMeals(int id);
		public MealEntity AddMeal(WriteOnlyMealDto mealDto);
        public MealEntity UpdateMeal(int id,WriteOnlyMealDto mealDto);
    }
}

