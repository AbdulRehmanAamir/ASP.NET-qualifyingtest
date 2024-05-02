using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double ItemTotalBill { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Orders { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }
        public int? SizeId { get; set; }
        [ForeignKey("SizeId")]
        public Size? Sizes { get; set; }





    }
}
