using MavenShopMasterPlanner.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public required string Name { get; set; }

        public decimal Quantity { get; set; }

        public virtual MeasutementUnit MeasurementUnit { get; set; }

        [ForeignKey("RecipeId")]
        public int RecipeId { get; set; }
        public required virtual Recipe Recipe { get; set; }
    }
}
