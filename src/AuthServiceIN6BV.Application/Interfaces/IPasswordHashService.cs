namespace AuthServiceIN6BV.Application.Interface;
public interface IPasswordHashService
{
    string HashPassword(string password);
    bool VerifyPassword (string password, string hashedPassword
    );
}