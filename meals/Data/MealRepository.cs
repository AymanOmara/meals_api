
using meals.Data;
using meals.Data.Meal;
using meals.Dto;
using Microsoft.EntityFrameworkCore;

public class MealRepository : IMealRepository
{

    private readonly MealsDBContext _context;
    public MealRepository(MealsDBContext context)
    {
        _context = context;
    }

    public List<MealEntity> GetMeals(int id)
    {
        return _context.Meals.Where(x => x.Category.Id == id).ToList();
    }
    public MealEntity AddMeal(WriteOnlyMealDto mealDto)
    {
        var recipe = _context.Recipes.FirstOrDefault(rec => rec.Id == mealDto.RecipeId);
        var category = _context.Categories.FirstOrDefault(rec => rec.Id == mealDto.CategoryId);
        MealEntity meal = new() { Recipe = recipe, Name = mealDto.Name, ImageUrl = mealDto.ImageUrl, Category = category };
        _context.Meals.Add(meal);
        _context.SaveChanges();
        return meal;
    }

    public MealEntity UpdateMeal(int id, WriteOnlyMealDto mealDto)
    {
        var recipe = _context.Recipes.FirstOrDefault(rec => rec.Id == mealDto.RecipeId);
        var category = _context.Categories.FirstOrDefault(rec => rec.Id == mealDto.CategoryId);
        var meal = _context.Meals.Include(meal=>meal.Recipe).FirstOrDefault(m => m.Id == id);
        meal.Recipe = recipe;
        meal.Name = mealDto.Name;
        meal.ImageUrl = mealDto.ImageUrl;
        meal.Category = category;
        _context.Entry(meal).State = EntityState.Modified;
        _context.SaveChanges();
        return meal;
    }
}

