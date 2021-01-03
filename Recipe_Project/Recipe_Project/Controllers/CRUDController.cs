using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipe_Project.Models;

namespace Recipe_Project.Controllers
{
    [Authorize]
    public class CRUDController : Controller
    {
        private IRecipeRepository recipeRepository;

        public CRUDController(IRecipeRepository repo)
        {
            recipeRepository = repo;
        }

        [HttpGet]
        public ViewResult AddRecipe(int id)
        {
            if (id != 0)
            {
                return View(recipeRepository.Mappings().FirstOrDefault(r => r.RecipeId == id));
            }
            else
            {
                return View(new RecipeIngredientMapping());
            }
        }

     
        [HttpGet]
        public ViewResult RecipeList()
        {
            // returning list of recipes
            return View(recipeRepository.Mappings());
        }

        [HttpPost]
        public IActionResult AddRecipe(RecipeIngredientMapping recipe)
        {
            if (ModelState.IsValid)
            {
                recipeRepository.SaveRecipe(recipe);
                var msg = "swal('Success', '" + recipe.RecipeName.ToString() + " has been saved successfully" + "','success')" + "";

                TempData["message"] = msg;
                return RedirectToAction("RecipeList");
            }
            else
            {
                return View(recipe);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Recipe deletedRecipe = recipeRepository.DeleteRecipe(id);

            if (deletedRecipe != null)
            {
                var msg = "swal('Success', '" + deletedRecipe.RecipeName.ToString() + " has been deleted" + "','success')" + "";
                TempData["message"] = msg;
            }

            return RedirectToAction("RecipeList");
        }

        public ViewResult ViewRecipe(int id)
        {
            // Fetching particular recipe and then sending it to another view
            var recipe = recipeRepository.Recipes.Where(r => r.RecipeId == id).FirstOrDefault();
            var ingredients = recipeRepository.Ingredients.Where(r => r.RecipeId == id).ToList();
            StringBuilder ingr = new StringBuilder("");
            foreach(RecipeIngredients recIngr in ingredients)
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
        public ViewResult ReviewRecipe(int id)
        {
            // Fetching particular recipe and then sending it to another view
            var recipe = recipeRepository.Recipes.Where(r => r.RecipeId == id).FirstOrDefault();
            return View(recipe);
        }
    }
}