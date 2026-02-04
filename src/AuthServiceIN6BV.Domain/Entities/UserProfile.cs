using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace AuthServiceIN6BV.Domain.Entities;

public class UserProfile
{
    [Key]
    [MaxLength(16)]
    public string Id {get ; set;} = string.Empty;
    [Required]
    [MaxLength(16)]
    public string UserId {get; set;} = string.Empty;
    [MaxLength(512)]
    public string ProfilePicture {get; set;}=string.Empty;

    [Required]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "El numero de telefono debe tener entre 8 y 16 caracteres")]
    [RegularExpression(@"^\d+$", ErrorMessage = "El telefono solo debe contener numeros")]
    public string Phone { get; set; } = string.Empty;

    [Required]
    public User User {get; set;} = null!;
}