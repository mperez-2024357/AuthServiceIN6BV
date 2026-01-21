using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
namespace AuthServiceIN6BV.Domain.Entities;

public class UserEmail
{
    [Key]
    [MaxLength(16)]
    public string Id {get; set;}= string.Empty;

    [Required]
    [MaxLength(16)]
    public string UsetId {get; set;} = string.Empty;

    [Required]
    public bool EmailVarified {get; set;} = false;

    public string? EmailVerificationToke {get;set;}

    public DateTime? EmailVerificationTokeExpiry {get; set;}

    [Required]
    public User User {get; set;} = null!;
}