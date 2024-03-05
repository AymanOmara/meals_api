﻿using System.ComponentModel.DataAnnotations;

namespace meals.Dto
{
	public class MealDto
	{
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}

