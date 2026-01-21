namespace AuthServiceIN6BV.Application.Interface;
public interface IpasswordHashService
{
    string hashPassword(string password);
    bool verifyPassword (string password, string hashedPassword
    );
}