using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.managers")]
    public class Manager
    {
        [Key]
        [Column("manager_id")]
        public int ManagerId { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string HashPassword { get; set; }
    }
}
