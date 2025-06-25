using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.employers")]
    public class Employer
    {
        [Key]
        [Column("employer_id")]
        public int EmployerId { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string HashPassword { get; set; }
    }
}
