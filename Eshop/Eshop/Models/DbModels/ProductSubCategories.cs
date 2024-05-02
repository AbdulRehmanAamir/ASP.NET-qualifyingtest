using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("ProductSubCategories")]
    public class ProductSubCategories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public ProductCategories ProductCategory {  get; set; }
    }
}
