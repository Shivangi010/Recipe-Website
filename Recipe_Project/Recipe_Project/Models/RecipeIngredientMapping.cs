using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Project.Models
{
    public class RecipeIngredientMapping
    {

        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Please enter recipe name")]
        public String RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter description of recipe")]
        public String RecipeDesc { get; set; }

        [Required(ErrorMessage = "Please enter chef name")]
        public String ChefName { get; set; }

        [Required(ErrorMessage = "Please enter list of ingredients")]
        public String Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter preparation time")]
        public String PrepTime { get; set; }

       
    }
}
