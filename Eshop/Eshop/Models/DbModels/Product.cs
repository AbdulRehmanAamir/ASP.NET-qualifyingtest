using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        public double? Price { get; set; }
        public int? RemainingStock { get; set; } 


        public int? ProductGenderId { get; set; }
        [ForeignKey ("ProductGenderId")]
        public ProductGender ProductGenders { get; set; }

        public int? ProductCategoriesId { get; set; }
        [ForeignKey("ProductCategoriesId")]
        public ProductCategories ProductCategory { get; set; }

        public int? ProductSubCategoriesId { get; set; }
        [ForeignKey("ProductSubCategories")]
        public ProductSubCategories ProductSubCategory { get; set; }
        public int? ProductTypeId { get; set; }
        [ForeignKey("ProductTypeId")]
        public ProductType ProductTypes { get; set; }

    }
}
