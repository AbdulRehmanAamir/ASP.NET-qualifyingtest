using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models.DbModels
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
  
        public DateTime? Dob {  get; set; }
        public string? Address { get; set; } 

        public int RoleId { get; set; }
        [ForeignKey ("RoleId")]
        public Role Roles { get; set; }
    }
}
