using System.Collections.Generic;

public class Employer
{
    public int EmployerId { get; set; }
    public string Login { get; set; }
    public string HashPassword { get; set; }
    public string OrganizationName { get; set; }
    public virtual ICollection<Vacancy> Vacancies { get; set; } = new HashSet<Vacancy>();
}