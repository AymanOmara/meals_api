namespace meals.Data
{
    public interface IIngredientRepository
    {
        public List<Ingredient> GetIngredients();
        public Ingredient AddIngredient(string ingredientName);
        public void DeleteIngredient(int id);
        public Ingredient UpdateIngredient(Ingredient ingredient);
    }
}

