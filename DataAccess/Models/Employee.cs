using System.Collections.Generic;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Login { get; set; }
    public string HashPassword { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public virtual ICollection<Deal> Deals { get; set; } = new HashSet<Deal>();
}