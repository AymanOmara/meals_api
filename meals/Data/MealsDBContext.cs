using Microsoft.EntityFrameworkCore;

namespace meals.Data
{
	public class MealsDBContext:DbContext
	{
		public MealsDBContext(DbContextOptions<MealsDBContext> options) :base(options)
		{

		}
		public DbSet<Category> Categories { get; set; }

        public DbSet<MealEntity> Meals { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }

	}
}

