﻿using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
    public class GetIngredientDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}