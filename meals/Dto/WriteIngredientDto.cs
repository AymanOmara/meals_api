using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
    public class WriteIngredientDto
    {
        [Required]
        public int Id { get; set; }
    }
}
