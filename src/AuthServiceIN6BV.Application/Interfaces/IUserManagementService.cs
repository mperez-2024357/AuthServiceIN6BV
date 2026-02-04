using AuthServiceIN6BV.Application.DTOs;
namespace AuthServiceIN6BV.Application.Interface;
public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRolAsync(string userId,string roleName);
    Task<IReadOnlyList<string>> GerUserRolesAsync (string userId);
    Task<IReadOnlyList<UserResponseDto>> GetUsersByRolesAsync (string roleName);
    
}