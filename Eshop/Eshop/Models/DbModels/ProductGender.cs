using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("ProductGender")]
    public class ProductGender
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

    }
}
