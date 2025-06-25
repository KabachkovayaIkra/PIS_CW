using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.employees")]
    public class Employee
    {
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("qualification")]
        public string Qualification { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("additional_info")]
        public string AdditionalInfo { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string HashPassword { get; set; }
    }
}
