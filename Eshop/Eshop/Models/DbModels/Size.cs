using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("Size")]
    public class Size
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }


    }
}
