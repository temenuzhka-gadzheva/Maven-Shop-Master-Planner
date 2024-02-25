using MavenShopMasterPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace MavenShopMasterPlanner.Data
{
    public class MavenShopMasterPlannerDbContext : DbContext
    {
        #pragma warning disable IDE0290
        public MavenShopMasterPlannerDbContext(DbContextOptions<MavenShopMasterPlannerDbContext> options)
         : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Allergen> Allergens { get; set; }
        public virtual DbSet<AllergenCategory> AllergenCategories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<FavoriteRecipe> FavoriteRecipes { get; set; }
        public virtual DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public virtual DbSet<NutritionDetail> NutritionDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual DbSet<SharedShoppingList> SharedShoppingLists { get; set; }
        public virtual DbSet<ShoppingList> ShoppingList { get; set; }
        public virtual DbSet<ShoppingListItem> ShoppingListItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
