using Microsoft.EntityFrameworkCore;

namespace meals.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MealsDBContext _context;
        public CategoryRepository(MealsDBContext context)
        {
            _context = context;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task DeleteCategory(int id)
        {
            var category = await GetCategoryById(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetRandomCategory()
        {
            var categories = GetCategories();
            Random rand = new();
            int index = rand.Next(categories.Count);
            return categories[index];
        }

        public async Task<Category> UpdateCategory(int id, Category category)
        {
            category.Id = id;
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return category;
        }
        private async Task<Category> GetCategoryById(int id) {
            return await _context.Categories.FindAsync(id);
        }
    }
}

