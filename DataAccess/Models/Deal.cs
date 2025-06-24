using System;

public class Deal
{
    public int DealId { get; set; }
    public int EmployeeId { get; set; }
    public int EmployerId { get; set; }
    public int VacancyId { get; set; }
    public int ManagerId { get; set; }
    public DateTime? DateOfSigning { get; set; }

    public virtual Employee Employee { get; set; }
    public virtual Employer Employer { get; set; }
    public virtual Vacancy Vacancy { get; set; }
    public virtual Manager Manager { get; set; }
}