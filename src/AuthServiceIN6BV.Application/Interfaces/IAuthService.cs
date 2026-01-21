using AuthServiceIN6BV.Application.DTOs;
using AuthServiceIN6BV.Application.DTOs.Email;
namespace AuthServiceIN6BV.Application.Interface;
public interface IAuthService
{
    Task<RegisterResponseDto> RegisterAsync (RegisterResponseDto registerDto);
    Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
    Task<EmailResponseDto> VerifyEmailAsync (VerifyEmailDto verifyEmailDto);
    Task<EmailResponseDto> ResendVerificationEmailAsinc (ResendVerificationDto resendDto);
    Task<EmailResponseDto> ForgotPasswordAsync (ForgorPasswordDto forgotPasswordDto);
    Task<EmailResponseDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    Task<UserResponseDto> GetUserByIdAsync(string userId);
}