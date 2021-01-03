using System.Collections.Generic;

namespace Recipe_Project.Models
{
    public class Repository
    {
        private static List<Recipe> recipeList = new List<Recipe>();

        public static IEnumerable<Recipe> ListOfRecipes
        {
            get
            {
                return recipeList;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipeList.Add(recipe);
        }
    }
}
