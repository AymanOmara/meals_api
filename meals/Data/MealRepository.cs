using AutoMapper;
using meals.Data;
using meals.Data.Meal;
using meals.Dto;
using Microsoft.EntityFrameworkCore;

public class MealRepository : IMealRepository
{

    private readonly MealsDBContext _context;

    private readonly IMapper _mapper;

    public MealRepository(MealsDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<MealEntity> GetMealsByCategoryId(int CategoryId)
    {
        return _context.Meals.Where(x => x.Category.Id == CategoryId).ToList();
    }

    public MealEntity AddMeal(WriteOnlyMealDto mealDto)
    {
        var meal = _mapper.Map<MealEntity>(mealDto);
        _context.Meals.Add(meal);
        _context.SaveChanges();
        return meal;
    }

    public MealEntity UpdateMeal(int id, WriteOnlyMealDto mealDto)
    {
        var updatedMeal = _mapper.Map<MealEntity>(mealDto);
        updatedMeal.Id = id;
        _context.Entry(updatedMeal).State = EntityState.Modified;
        _context.SaveChanges();
        return updatedMeal;
    }

    public void DeleteMeal(int id)
    {
        var meal = _context.Meals.FirstOrDefault(meal => meal.Id == id);
        _context.Meals.Remove(meal);
        _context.SaveChanges();
    }
}

