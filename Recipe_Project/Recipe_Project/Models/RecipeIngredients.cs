using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Project.Models
{
    public class RecipeIngredients
    {

        public int id { get; set; }

        public int RecipeId { get; set; }

        public String IngredientName { get; set; }
    }
}
