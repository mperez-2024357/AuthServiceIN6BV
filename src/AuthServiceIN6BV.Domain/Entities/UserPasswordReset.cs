using System.ComponentModel.DataAnnotations;
using System.Data.Common;
namespace AuthServiceIN6BV.Domain.Entities;
public class UserPasswordReset
{
    [Key]
    [MaxLength(16)]
    public String Id {get; set;} = string.Empty;
    
    [Required]
    [MaxLength(16)]
    public string UserId {get; set;}= string.Empty;
    [MaxLength(255)]
    public string? PasswordResetToken {get; set;}

    public DateTime? PasswordResetTokenExpiry {get; set;}

    [Required]
    public User User {get;set;} = null!;
}