using Microsoft.EntityFrameworkCore;

namespace meals.Data
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly MealsDBContext _context;
        public IngredientRepository(MealsDBContext context)
        {
            _context = context;
        }

        public Ingredient AddIngredient(string ingredientName)
        {
            var ingredient = new Ingredient() { Name = ingredientName };
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient;
        }

        public void DeleteIngredient(int id)
        {
            //var ingredient = _context.Ingredients.FirstOrDefault(ing => ing.Id == id);
            //ingredient.Deleted = true;
            _context.SaveChanges();
        }

        public List<Ingredient> GetIngredients()
        {
            return _context.Ingredients.Where(ing => ing.Deleted == false).ToList();
        }

        public Ingredient UpdateIngredient(Ingredient ingredient)
        {
            _context.Entry(ingredient).State = EntityState.Modified;
            _context.SaveChanges();
            return ingredient;
        }
    }
}

