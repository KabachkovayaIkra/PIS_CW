using System.Collections.Generic;

public class Manager
{
    public int ManagerId { get; set; }
    public string Login { get; set; }
    public string HashPassword { get; set; }
    public string FullName { get; set; }
    public virtual ICollection<Deal> Deals { get; set; } = new HashSet<Deal>();
}