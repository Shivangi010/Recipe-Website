using Microsoft.EntityFrameworkCore;

namespace Recipe_Project.Models
{
    public class ApplicationContextDB : DbContext
    {
        public ApplicationContextDB(DbContextOptions<ApplicationContextDB> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
    }
}
