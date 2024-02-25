using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class AllergenCategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public required string Name { get; set; }
        public required virtual ICollection<Allergen> Allergens { get; set; }
    }
}
