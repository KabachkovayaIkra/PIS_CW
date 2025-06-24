using System.Collections.Generic;

public interface IFacadeEmployer
{
    int CreateVacancy(int employerId, string profession, int typeOfBusinessId, double salary, string info);
    List<Vacancy> ListVacancies(int employerId);
    List<TypeOfBusiness> ListBusinessTypes();
}