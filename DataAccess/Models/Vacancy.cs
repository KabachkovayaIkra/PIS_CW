using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("public.vacancies")]
    public class Vacancy
    {
        [Key]
        [Column("vacancy_id")]
        public int VacancyId { get; set; }

        [Column("employer_id")]
        public int EmployerId { get; set; }

        [Column("profession")]
        public string Profession { get; set; }

        [Column("type_of_business_id")]
        public int TypeOfBusinessId { get; set; }

        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("vacancy_info")]
        public string VacancyInfo { get; set; }

        [Column("vacancy_status")]
        public string VacancyStatus { get; set; }
    }
}
