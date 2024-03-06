using meals.Dto;

namespace meals.Data
{
    public interface IRecipeRepository
    {
        public List<Recipe> GetRecipes();
        public void DeleteRecipe(int id);
        public Task<Recipe> AddRecipe(AddRecipeDto recipe);
        public Task<Recipe> UpdateRecipe(int id,AddRecipeDto recipe);

    }
}

