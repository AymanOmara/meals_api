using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class WriteOnlyCategoryDto
	{
        [Required]
        public String Name { get; set; }
        [Required]
        public String ImagUrl { get; set; }
    }
}

