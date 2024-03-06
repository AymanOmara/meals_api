using meals.Dto;
using Microsoft.EntityFrameworkCore;

namespace meals.Data
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly MealsDBContext _context;

        public RecipeRepository(MealsDBContext context)
        {
            _context = context;
        }

        public void DeleteRecipe(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(rec => rec.Id == id);
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
        }

        public List<Recipe> GetRecipes()
        {
            var recirpeis = _context.Recipes.Include(r => r.IngredientRecipes).ThenInclude(x => x.Ingredient).Include(rec => rec.Meal).ToList();

            return recirpeis;
        }
        public async Task<Recipe> AddRecipe(AddRecipeDto recipeDto)
        {
            List<IngredientRecipe> ingredientRecipes = new();
            foreach (var ingredient in recipeDto.IngredientRecipes)
            {
                IngredientRecipe ingredientRecipe = new() { Ingredient = _context.Ingredients.FirstOrDefault(ing => ing.Id == ingredient.Id), IngredientCountInGM = ingredient.IngredientCountInGM };
                ingredientRecipes.Add(ingredientRecipe);
                _context.IngredientRecipes.Add(ingredientRecipe);
            }
            await _context.SaveChangesAsync();
            Recipe recipe = new() { IngredientRecipes = ingredientRecipes, Name = recipeDto.Name, };
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
            foreach (var v in ingredientRecipes)
            {
                v.Recipe = recipe;
                _context.SaveChanges();
            }
            return recipe;
        }
        public async Task<Recipe> UpdateRecipe(int id, AddRecipeDto recipeDto)
        {
            List<IngredientRecipe> ingredientRecipes = new();
            foreach (var ingredient in recipeDto.IngredientRecipes)
            {
                IngredientRecipe ingredientRecipe = new() { Ingredient = _context.Ingredients.FirstOrDefault(ing => ing.Id == ingredient.Id), IngredientCountInGM = ingredient.IngredientCountInGM };
                ingredientRecipes.Add(ingredientRecipe);
                _context.IngredientRecipes.Add(ingredientRecipe);
            }
            await _context.SaveChangesAsync();
            Recipe recipe = _context.Recipes.FirstOrDefault(recipe => recipe.Id == id);
            recipe.IngredientRecipes = ingredientRecipes;
            recipe.Name = recipeDto.Name;
            _context.Entry(recipe).State = EntityState.Modified;
            _context.SaveChanges();
            foreach (var v in ingredientRecipes)
            {
                v.Recipe = recipe;
                _context.SaveChanges();
            }
            return recipe;
        }
    }
}

