using MavenShopMasterPlanner.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public required string FirstName { get; set; }

        [StringLength(30)]
        public required string LastName { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string? ProfileImageUrl { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public required string PhoneNumber { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required virtual ICollection<FavoriteRecipe>? FavoriteRecipes { get; set; }
        public required virtual ICollection<FavoriteProduct>? FavoriteProducts { get; set; }
        public required virtual ICollection<Recipe>? Recipes { get; set; }
        public required virtual ICollection<ShoppingList>? ShoppingLists { get; set; }
        public required virtual ICollection<ShoppingListItem>? ShoppingListItems { get; set; }
    }
}
