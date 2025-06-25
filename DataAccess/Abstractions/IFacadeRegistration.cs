public interface IFacadeRegistration
{
    int RegisterEmployer(string login, string password, string orgName);
    int RegisterEmployee(string login, string password, string firstName, string lastName, string middleName);
}