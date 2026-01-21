namespace AuthServiceIN6BV.Application.Interface;
public interface IEmailService
{
    Task sendEmailVerificationAsync(string email, string username,string token);
    Task SendPasswordResetAsync(string email, string username, string token);
    Task SendWelcomeEmailAsync(string email , string userna);
    
}