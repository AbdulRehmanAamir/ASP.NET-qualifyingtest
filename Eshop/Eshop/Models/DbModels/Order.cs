using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? TotalBill { get; set; }  

        public int? UserId { get; set; }
        [ForeignKey ("UserId")]
        public Users? User {  get; set; }
    }
}
