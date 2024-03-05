using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class CreateMealDto
	{
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ImagUrl { get; set; }
    }
}

