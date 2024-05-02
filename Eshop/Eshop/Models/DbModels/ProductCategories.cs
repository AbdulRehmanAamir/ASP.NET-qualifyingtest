using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("ProductCategories")]
    public class ProductCategories
    {
        [Key]
        public int Id { get; set; }
        public String Name {get; set;}

        public int ProductGenderId { get; set; }
        [ForeignKey ("ProductGenderId")]
        public ProductGender ProductGenders { get; set; }

    }
}
