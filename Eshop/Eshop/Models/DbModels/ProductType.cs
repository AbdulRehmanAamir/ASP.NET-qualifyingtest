using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("ProductType")]
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProductSubCategoriesId { get; set; }
        [ForeignKey ("ProductSubCategoriesId")]
        public ProductSubCategories ProductSubCategory { get; set; }
    }
}
