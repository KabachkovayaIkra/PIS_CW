using System.Collections.Generic;

public interface IFacadeEmployee
{
    List<Vacancy> SearchVacancies(string filter);
    bool ApplyForVacancy(int employeeId, int vacancyId);
    List<Deal> ListDealsForEmployee(int employeeId);
}