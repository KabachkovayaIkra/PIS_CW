using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.deals")]
    public class Deal
    {
        [Key]
        [Column("deal_id")]
        public int DealId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("employer_id")]
        public int EmployerId { get; set; }

        [Column("vacancy_id")]
        public int VacancyId { get; set; }

        [Column("commission")]
        public decimal Commission { get; set; }

        [Column("deal_status")]
        public string DealStatus { get; set; }

        [Column("date_of_signing")]
        public DateTime DateOfSigning { get; set; }
    }
}
