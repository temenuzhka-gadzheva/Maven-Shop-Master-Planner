using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class ShoppingListItem
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public required string Name { get; set; }

        public string? ImageUrl { get; set; }
        public decimal Quantity { get; set; }
        public bool IsPutchased { get; set; }

        [ForeignKey("ShoppingListId")]
        public int ShoppingListId { get; set; }
        public required virtual ShoppingList ShoppingList { get; set; }
    }
}
