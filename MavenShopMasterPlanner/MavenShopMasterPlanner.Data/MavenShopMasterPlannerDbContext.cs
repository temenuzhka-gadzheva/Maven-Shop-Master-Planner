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

            // Configure the precision and scale for decimal properties
            modelBuilder.Entity<NutritionDetail>()
                .Property(nd => nd.Carbohydrates)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<NutritionDetail>()
                .Property(nd => nd.Fats)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<NutritionDetail>()
                .Property(nd => nd.Protein)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<RecipeIngredient>()
                .Property(ri => ri.Quantity)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<ShoppingListItem>()
                .Property(sli => sli.Quantity)
                .HasColumnType("decimal(18, 2)");

            // Configure the relationship between User and FavoriteRecipe to prevent cascade delete
            modelBuilder.Entity<FavoriteRecipe>()
                .HasOne(fr => fr.User)
                .WithMany(u => u.FavoriteRecipes)
                .HasForeignKey(fr => fr.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure the relationship between User and FavoriteProduct to prevent cascade delete
            modelBuilder.Entity<FavoriteProduct>()
                .HasOne(fr => fr.User)
                .WithMany(u => u.FavoriteProducts)
                .HasForeignKey(fr => fr.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SharedShoppingList>()
                .HasOne(ssl => ssl.SharedWithUser)
                .WithMany(u => u.SharedShoppingLists)
                .HasForeignKey(ssl => ssl.SharedWithUserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
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
