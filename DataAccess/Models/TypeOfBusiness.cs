using System.Collections.Generic;

public class TypeOfBusiness
{
    public int TypeOfBusinessId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Vacancy> Vacancies { get; set; } = new HashSet<Vacancy>();
}