using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class SharedShoppingList
    {
        [Key]
        public int Id { get; set; }

        public DateTime SharedOn { get; set; }

        [ForeignKey("ShoppingListId")]
        public int ShoppingListId { get; set; }
        public required virtual ShoppingList ShoppingList { get; set; }

        [ForeignKey("SharedWithUserId")]
        public int SharedWithUserId { get; set; }
        public required virtual User SharedWithUser { get; set; }
    }
}
