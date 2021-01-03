using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Recipe_Project.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationContextDB context = app.ApplicationServices.GetRequiredService<ApplicationContextDB>();

            if (context.Database.EnsureCreated())
            {
                context.Database.Migrate();
            }

            if (!context.Recipes.Any())
            {
                RecipeIngredients recipeIngredients;
                Recipe latestRecipe;
                string Ingredients;
                List<string> ingredientNames;
                //Recipe 1
                context.Recipes.Add(
                    new Recipe
                    {
                        RecipeName = "Tomato Soup",
                        RecipeDesc = "Tomato Soup",
                        ChefName = "Harsh Shah",
                        PrepTime = "15 Mins"
                    });
                context.SaveChanges();
                // Recipe 1's Ingredients
                Ingredients = "Tomato, Water, Melted Cheese, Black Pepper";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();
                // Recipe 2
                context.Recipes.Add(new Recipe
                    {
                        RecipeName = "Egg Curry",
                        RecipeDesc = "Curry mixed with boiled egg",
                        ChefName = "Bharat Shah",
                        PrepTime = "55 Mins"
                    });
                context.SaveChanges();
                // Recipe 2 Ingredients
                Ingredients = "Egg, Turmeric, Butter, Black Pepper";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                // Recipe 3
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Fettuccine Alfredo",
                    RecipeDesc = "Italian pasta dish of fresh fettuccine tossed with butter and Parmesan cheese",
                    ChefName = "Dennis",
                    PrepTime = "45 Mins"
                });
                context.SaveChanges();
                // Recipe 3 Ingredients
                Ingredients = "Egg, flour, Butter, Parmesan Cheese";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();

                // Recipe 4
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Mango Pudding",
                    RecipeDesc = "Seasonal dish with frozen mangoes , milk , sugar and cream essence",
                    ChefName = "Karen",
                    PrepTime = "35 Mins"
                });
                context.SaveChanges();
                // Recipe 4 Ingredients
                Ingredients = "Frozen Mangoes, Cream, Milk, Sugar";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();

                // Recipe 5
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Rice Cutlet",
                    RecipeDesc = "Indian dish with cooked rice , chillies , carrots and beetroot",
                    ChefName = "Karen",
                    PrepTime = "55 Mins"
                });
                context.SaveChanges();
                // Recipe 5 Ingredients
                Ingredients = "Rice, Chillies, Carrots, Beetroot";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();

                // Recipe 6
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Bombay Potatoes",
                    RecipeDesc = "Indian dish with boiled potatoes, chillies , tomatoes and garlic",
                    ChefName = "Kirat",
                    PrepTime = "45 Mins"
                });
                context.SaveChanges();
                // Recipe 6 Ingredients
                Ingredients = "Potatoes, Tomatoes, Chillies, Garlic";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();

                // Recipe 7
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Sesame Naan Bread",
                    RecipeDesc = "The ideal accompaniment to any curry dish with crunch of sesame seeds",
                    ChefName = "Rehana",
                    PrepTime = "45 Mins"
                });
                context.SaveChanges();
                // Recipe 7 Ingredients
                Ingredients = "Sesame seeds, Butter, Caster Sugar, Milk";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();

                // Recipe 8
                context.Recipes.Add(new Recipe
                {
                    RecipeName = "Red Split Lentils",
                    RecipeDesc = "Indian-inspired lentils the whole family will love and babies, too",
                    ChefName = "Katie",
                    PrepTime = "25 Mins"
                });
                context.SaveChanges();
                // Recipe 8 Ingredients
                Ingredients = "Red Lentils, Onion, Coriander, Salt";
                ingredientNames = Ingredients.Split(",").ToList();
                latestRecipe = context.Recipes.OrderByDescending(temp => temp.RecipeId).First();
                foreach (string str in ingredientNames)
                {
                    recipeIngredients = new RecipeIngredients();
                    recipeIngredients.IngredientName = str.Trim();
                    recipeIngredients.RecipeId = latestRecipe.RecipeId;
                    context.RecipeIngredients.Add(recipeIngredients);
                }
                context.SaveChanges();
                

            }
        }
    }
}
