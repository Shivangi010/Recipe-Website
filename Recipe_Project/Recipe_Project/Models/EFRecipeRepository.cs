using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe_Project.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationContextDB context;

        public EFRecipeRepository(ApplicationContextDB ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;

        public IQueryable<RecipeIngredients> Ingredients => context.RecipeIngredients;

        public IQueryable<RecipeIngredientMapping> Mappings()
        {
            /*var result = (from p in context.Recipes
                          join o in context.RecipeIngredients on p.RecipeId equals o.RecipeId
                          select new
                          {
                              p.RecipeId,
                              p.RecipeName,
                              p.RecipeDesc,
                              p.PrepTime,
                              p.ChefName,
                              o.IngredientName
                          }).ToList();

            List<RecipeIngredientMapping> mappings = new List<RecipeIngredientMapping>();
            RecipeIngredientMapping tempVar = new RecipeIngredientMapping();
            foreach (var rec in result)
            {
                tempVar.RecipeId = rec.RecipeId,
                tempVar.RecipeName = rec.RecipeName,
                tempVar.RecipeDesc = tempVar.RecipeDesc,
                tempVar.Ingredients 
            }
            return  recipeIngredientMapping = result;*/

            var recipes = context.Recipes;
            List<RecipeIngredientMapping> mappings = new List<RecipeIngredientMapping>();
            RecipeIngredientMapping tempVar;
            foreach(var temp in recipes)
            {
                var ingredients = context.RecipeIngredients.Where(i => i.RecipeId == temp.RecipeId).ToList();
                StringBuilder ingr = new StringBuilder("");
                foreach (RecipeIngredients recIngr in ingredients)
                {
                    ingr.Append(recIngr.IngredientName);
                    ingr.Append(", ");
                }
                int length = ingr.ToString().Length;
                tempVar = new RecipeIngredientMapping();
                tempVar.RecipeId = temp.RecipeId;
                tempVar.RecipeName = temp.RecipeName;
                tempVar.RecipeDesc = temp.RecipeDesc;
                tempVar.Ingredients = ingr.ToString().Substring(0, length - 2);
                tempVar.PrepTime = temp.PrepTime;
                tempVar.ChefName = temp.ChefName;
                mappings.Add(tempVar);
            }

            return mappings.AsQueryable();
        }

        public void SaveRecipe(RecipeIngredientMapping recipe)
        {
            if (recipe.RecipeId == 0)
            {
                Recipe recipeInstance = new Recipe();
                recipeInstance.RecipeName = recipe.RecipeName;
                recipeInstance.RecipeDesc = recipe.RecipeDesc;
                recipeInstance.PrepTime = recipe.PrepTime;
                recipeInstance.ChefName = recipe.ChefName;
                context.Recipes.Add(recipeInstance);
                context.SaveChanges();
                Recipe latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                List<string> ingredientNames = new List<string>();
                ingredientNames.AddRange(recipe.Ingredients.Split(","));
                int count = ingredientNames.Count;
                RecipeIngredients recipeIngredients;
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
            }
            else
            {
                Recipe RecipeEntry = context.Recipes
                    .FirstOrDefault(p => p.RecipeId == recipe.RecipeId);

                List<RecipeIngredients> ingredients = context.RecipeIngredients.Where(ingr => ingr.RecipeId == recipe.RecipeId).ToList();

                if (RecipeEntry != null)
                {
                    context.RecipeIngredients.RemoveRange(ingredients);
                    RecipeEntry.RecipeName = recipe.RecipeName;
                    RecipeEntry.RecipeDesc = recipe.RecipeDesc;
                    RecipeEntry.ChefName = recipe.ChefName;
                    RecipeEntry.PrepTime = recipe.PrepTime;
                    List<string> ingredientNames = new List<string>();
                    ingredientNames.AddRange(recipe.Ingredients.Split(","));
                    int count = ingredientNames.Count;
                    RecipeIngredients recipeIngredients;
                    foreach(string str in ingredientNames)
                    {
                        recipeIngredients = new RecipeIngredients();
                        recipeIngredients.IngredientName = str.Trim();
                        recipeIngredients.RecipeId = recipe.RecipeId;
                        context.RecipeIngredients.Add(recipeIngredients);
                    }
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int RecipeID)
        {
            Recipe RecipeEntry = context.Recipes
                .FirstOrDefault(p => p.RecipeId == RecipeID);

            if (RecipeEntry != null)
            {
                context.RecipeIngredients.RemoveRange(context.RecipeIngredients.Where(rec => rec.RecipeId == RecipeID).ToList());
                context.Recipes.Remove(RecipeEntry);
                context.SaveChanges();
            }

            return RecipeEntry;
        }
    }
}
