using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy {  get; set; }

        public string Updateby { get; set;}
        public DateTime UpdateDate { get; set; }

        public string Deleteby { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}
