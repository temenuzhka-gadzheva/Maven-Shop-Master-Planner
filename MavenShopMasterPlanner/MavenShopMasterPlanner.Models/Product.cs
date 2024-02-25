using MavenShopMasterPlanner.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public required string Name { get; set; }

        public required ProductCategory ProductCategory { get; set; }

        [ForeignKey("NutritionDetailsId")]
        public int NutritionDetailsId { get; set; }
        public required virtual NutritionDetail NutritionDetails { get; set; }

        public string? ImageUrl { get; set; }

        [StringLength(500, MinimumLength = 5)]
        [DataType(DataType.MultilineText)]
        public required string StorageInstructions { get; set; }
        public bool HasAllergens { get; set; }
        public virtual ICollection<Allergen>? Allergens { get; set; }
    }
}
