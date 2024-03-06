using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meals.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; } = null!;

        public bool Deleted { get; set; }

        [Required]
        public String ImagUrl { get; set; } = null!;

        [ForeignKey("MealId")]
        public ICollection<MealEntity>? Meals { get; set; }
    }
}

