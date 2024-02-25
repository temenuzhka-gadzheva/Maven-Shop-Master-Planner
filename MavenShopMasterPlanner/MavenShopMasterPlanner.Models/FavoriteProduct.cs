using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class FavoriteProduct
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public required virtual Product Product { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public required virtual User User { get; set; }
    }
}
