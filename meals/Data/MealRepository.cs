
using meals.Data;
using meals.Data.Meal;

public class MealRepository: IMealRepository
{

    private readonly MealsDBContext _context;
    public MealRepository(MealsDBContext context)
    {
        _context = context;
    }

    public List<MealEntity> GetMeals(int id)
    {
        return _context.Meals.Where(x=>x.Category.Id == id).ToList();
    }

}

