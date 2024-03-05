namespace meals.Data.Meal
{
	public interface IMealRepository
	{
		public List<MealEntity> GetMeals(int id);
	}
}

