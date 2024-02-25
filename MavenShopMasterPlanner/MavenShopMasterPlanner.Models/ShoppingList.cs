using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public required string Name { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("OwnerId")]
        public int OwnerId { get; set; }
        public required virtual User Owner { get; set; }
        public virtual ICollection<ShoppingListItem>? Items { get; set; }
    }
}
