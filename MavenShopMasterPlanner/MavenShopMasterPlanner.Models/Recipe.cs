using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public required string Name { get; set; }
        public TimeSpan CookingTime { get; set; }
        public TimeSpan PreparationTime { get; set; }
        public int PortionCount { get; set; }

        [ForeignKey("OwnerId")]
        public int OwnerId { get; set; }
        public required virtual User Owner { get; set; }
        public required virtual ICollection<RecipeIngredient> Ingredients { get; set; }
    }
}
