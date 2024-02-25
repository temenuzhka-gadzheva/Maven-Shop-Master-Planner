using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class FavoriteRecipe
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RecipeId")]
        public int RecipeId { get; set; }
        public required virtual Recipe Recipe { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public required virtual User User { get; set; }
    }
}
