using System.ComponentModel.DataAnnotations;

namespace MavenShopMasterPlanner.Models
{
    public class NutritionDetail
    {
        [Key]
        public int Id { get; set; }

        public decimal Carbohydrates { get; set; }
        public decimal Fats { get; set; }
        public decimal Protein { get; set; }
        public required virtual ICollection<Product> Products { get; set; }
    }
}
