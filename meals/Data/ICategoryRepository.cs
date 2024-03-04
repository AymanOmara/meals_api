namespace meals.Data
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

        public Task<Category> CreateCategory(Category category);

        public Task<Category> UpdateCategory(int id, Category category);

        public Task DeleteCategory(int id);

        public Category GetRandomCategory();
    }
}

