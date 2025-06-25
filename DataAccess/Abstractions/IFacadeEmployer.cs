using System.Collections.Generic;
using DataAccess.Models;

public interface IFacadeEmployer
{
    int CreateVacancy(int employerId, string profession, int typeOfBusinessId, decimal salary, string info);
    List<Vacancy> ListVacancies(int employerId);
    List<TypeOfBusiness> ListBusinessTypes();
}