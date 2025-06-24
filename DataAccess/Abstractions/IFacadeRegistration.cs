public interface IFacadeRegistration
{
    int RegisterManager(string login, string password, string name);
    int RegisterEmployer(string login, string password, string orgName);
    int RegisterEmployee(string login, string password, string firstName, string lastName, string middleName);
}