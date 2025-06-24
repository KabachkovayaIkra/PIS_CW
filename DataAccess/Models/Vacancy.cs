using System.Collections.Generic;

public class Vacancy
{
    public int VacancyId { get; set; }
    public int EmployerId { get; set; }
    public int TypeOfBusinessId { get; set; }
    public string Profession { get; set; }
    public double Salary { get; set; }
    public string VacancyInfo { get; set; }
    public string VacancyStatus { get; set; }
    public virtual Employer Employer { get; set; }
    public virtual TypeOfBusiness TypeOfBusiness { get; set; }
    public virtual ICollection<Deal> Deals { get; set; } = new HashSet<Deal>();
}