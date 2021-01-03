using Microsoft.AspNetCore.Mvc;
using Recipe_Project.Models;
using System.Linq;
using System.Text;

namespace Recipe_Project.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository recipeRepository;
        public HomeController(IRecipeRepository repo)
        {
            recipeRepository = repo;
        }
        public ViewResult Index()
        {
            return View(recipeRepository.Mappings());
        }

        public ViewResult ViewRecipe(int id)
        {
            // Fetching particular recipe and then sending it to another view
            var recipe = recipeRepository.Recipes.Where(r => r.RecipeId == id).FirstOrDefault();
            var ingredients = recipeRepository.Ingredients.Where(r => r.RecipeId == id).ToList();
            StringBuilder ingr = new StringBuilder("");
            foreach (RecipeIngredients recIngr in ingredients)
            {
                ingr.Append(recIngr.IngredientName);
                ingr.Append(", ");
            }
            int length = ingr.ToString().Length;
            //var recipe = Repository.ListOfRecipes.Where(r => r.RecipeId == id).FirstOrDefault();
            RecipeIngredientMapping mapping = new RecipeIngredientMapping
            {
                ChefName = recipe.ChefName,
                RecipeDesc = recipe.RecipeDesc,
                RecipeName = recipe.RecipeName,
                Ingredients = ingr.ToString().Substring(0, length - 2),
                PrepTime = recipe.PrepTime,
                RecipeId = recipe.RecipeId
            };
            return View(mapping);
        }
        /*[HttpPost]
        public ViewResult RecipeForm(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                // Adding recipe id to recipe object and then adding the object to repository
                recipe.RecipeId = Repository.ListOfRecipes.Count() + 1;
                Repository.AddRecipe(recipe);
                return View("RecipeList", Repository.ListOfRecipes);
            }
            else
            {
                return View("AddRecipe");
            }
        }*/


    }
}