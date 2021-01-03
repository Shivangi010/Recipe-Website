using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recipe_Project.Models;

namespace Recipe_Project
{
    public class Startup
    {
        //public property
        public IConfiguration Configuration { get; }

        //constructor
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContextDB>(options => options.UseSqlServer(Configuration["Data:RecipeStoreRecipes:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:RecipeStoreIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IRecipeRepository, EFRecipeRepository>();

            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            /*app.UseMvc(routes =>
            {

               

                routes.MapRoute(
                    name: null,
                    template: "/AddRecipe",
                    defaults: new { controller = "CRUD", action = "AddRecipe" }
                );

                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });*/
            app.UseMvcWithDefaultRoute();

                SeedData.EnsurePopulated(app);
                IdentitySeedData.EnsurePopulated(app);
        }
    }
}
