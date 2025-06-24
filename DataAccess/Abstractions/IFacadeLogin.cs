public interface IFacadeLogin
{
    bool AuthManager(string login, string password);
    bool AuthEmployer(string login, string password);
    bool AuthEmployee(string login, string password);
}