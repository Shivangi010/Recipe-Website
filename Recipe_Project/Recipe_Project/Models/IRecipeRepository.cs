using System.Linq;

namespace Recipe_Project.Models
{
    public interface IRecipeRepository
    {

        IQueryable<Recipe> Recipes { get; }

        IQueryable<RecipeIngredients> Ingredients { get; }

        void SaveRecipe(RecipeIngredientMapping Recipe);

        Recipe DeleteRecipe(int RecipeID);

        IQueryable<RecipeIngredientMapping> Mappings();

    }
}
