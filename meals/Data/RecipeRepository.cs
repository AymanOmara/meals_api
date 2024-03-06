using AutoMapper;
using meals.Dto;
using Microsoft.EntityFrameworkCore;

namespace meals.Data
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly MealsDBContext _context;
        private readonly IMapper _imapper;

        public RecipeRepository(MealsDBContext context, IMapper imapper)
        {
            _context = context;
            _imapper = imapper;
        }

        public void DeleteRecipe(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(rec => rec.Id == id);
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
        }

        public List<Recipe> GetRecipes()
        {
            var recirpeis = _context.Recipes
                .Include(r => r.IngredientRecipes)
                .ThenInclude(x => x.Ingredient).ToList();

            return recirpeis;
        }
        public async Task<Recipe> AddRecipe(AddRecipeDto recipeDto)
        {
            Recipe recipe = _imapper.Map<Recipe>(recipeDto);
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }
        public async Task<Recipe> UpdateRecipe(int id, AddRecipeDto recipeDto)
        {
            Recipe recipe = _imapper.Map<Recipe>(recipeDto);
            _context.Entry(recipe).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return recipe;
        }
    }
}

