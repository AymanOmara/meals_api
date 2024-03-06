using meals.Dto;

namespace meals.Data.Meal
{
    public interface IMealRepository
    {
        public List<MealEntity> GetMealsByCategoryId(int CategoryId);
        public MealEntity AddMeal(WriteOnlyMealDto mealDto);
        public MealEntity UpdateMeal(int id, WriteOnlyMealDto mealDto);
        public void DeleteMeal(int id);
    }
}

