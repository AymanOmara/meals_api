using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class MealDto
	{
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ImagUrl { get; set; }
    }
}

