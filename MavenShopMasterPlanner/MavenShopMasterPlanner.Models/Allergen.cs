using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MavenShopMasterPlanner.Models
{
    public class Allergen
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public required string Name { get; set; }

        [ForeignKey("AllergenCategory")]
        public int AllergenCategoryId { get; set; }

        public required virtual AllergenCategory AllergenCategory { get; set; }
    }
}
