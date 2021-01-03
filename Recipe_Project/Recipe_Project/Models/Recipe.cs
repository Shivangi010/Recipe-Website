using System;
using System.ComponentModel.DataAnnotations;

namespace Recipe_Project.Models
{
    public class Recipe
    {

        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Please enter recipe name")]
        public String RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter description of recipe")]
        public String RecipeDesc { get; set; }

        [Required(ErrorMessage = "Please enter chef name")]
        public String ChefName { get; set; }

        [Required(ErrorMessage = "Please enter preparation time")]
        public String PrepTime { get; set; }

        public String Review { get; set; }

        
    }
}
