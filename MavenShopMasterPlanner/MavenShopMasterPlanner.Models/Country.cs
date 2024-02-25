using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public required string Name { get; set; }

        public required string FlagImageUrl { get; set; }
    }
}
