﻿// <auto-generated />
using System;
using MavenShopMasterPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MavenShopMasterPlanner.Data.Migrations
{
    [DbContext(typeof(MavenShopMasterPlannerDbContext))]
    partial class MavenShopMasterPlannerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Allergen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AllergenCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AllergenCategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Allergens");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.AllergenCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("AllergenCategories");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FlagImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.FavoriteProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteProducts");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.FavoriteRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("FavoriteRecipes");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.NutritionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Carbohydrates")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Fats")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Protein")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("NutritionDetails");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("HasAllergens")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("NutritionDetailsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategory")
                        .HasColumnType("int");

                    b.Property<string>("StorageInstructions")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("NutritionDetailsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("CookingTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PortionCount")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("PreparationTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MeasurementUnit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.SharedShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("SharedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("SharedWithUserId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SharedWithUserId");

                    b.HasIndex("ShoppingListId");

                    b.ToTable("SharedShoppingLists");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.ShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.ShoppingListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPutchased")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ShoppingListId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingListId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingListItems");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Allergen", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.AllergenCategory", "AllergenCategory")
                        .WithMany("Allergens")
                        .HasForeignKey("AllergenCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MavenShopMasterPlanner.Models.Product", null)
                        .WithMany("Allergens")
                        .HasForeignKey("ProductId");

                    b.Navigation("AllergenCategory");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.FavoriteProduct", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MavenShopMasterPlanner.Models.User", "User")
                        .WithMany("FavoriteProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.FavoriteRecipe", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MavenShopMasterPlanner.Models.User", "User")
                        .WithMany("FavoriteRecipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Product", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.NutritionDetail", "NutritionDetails")
                        .WithMany("Products")
                        .HasForeignKey("NutritionDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NutritionDetails");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Recipe", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.User", "Owner")
                        .WithMany("Recipes")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.RecipeIngredient", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.SharedShoppingList", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.User", "SharedWithUser")
                        .WithMany("SharedShoppingLists")
                        .HasForeignKey("SharedWithUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MavenShopMasterPlanner.Models.ShoppingList", "ShoppingList")
                        .WithMany()
                        .HasForeignKey("ShoppingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SharedWithUser");

                    b.Navigation("ShoppingList");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.ShoppingList", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.User", "Owner")
                        .WithMany("ShoppingLists")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.ShoppingListItem", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.ShoppingList", "ShoppingList")
                        .WithMany("Items")
                        .HasForeignKey("ShoppingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MavenShopMasterPlanner.Models.User", null)
                        .WithMany("ShoppingListItems")
                        .HasForeignKey("UserId");

                    b.Navigation("ShoppingList");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.User", b =>
                {
                    b.HasOne("MavenShopMasterPlanner.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.AllergenCategory", b =>
                {
                    b.Navigation("Allergens");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.NutritionDetail", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Product", b =>
                {
                    b.Navigation("Allergens");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.ShoppingList", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("MavenShopMasterPlanner.Models.User", b =>
                {
                    b.Navigation("FavoriteProducts");

                    b.Navigation("FavoriteRecipes");

                    b.Navigation("Recipes");

                    b.Navigation("SharedShoppingLists");

                    b.Navigation("ShoppingListItems");

                    b.Navigation("ShoppingLists");
                });
#pragma warning restore 612, 618
        }
    }
}