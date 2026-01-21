using AuthServiceIN6BV.Domain.Entities;

namespace AuthServiceIN6BV.Application.Interface;
public interface IJwtTokenService
{
    string GenerateToken(User user);
}