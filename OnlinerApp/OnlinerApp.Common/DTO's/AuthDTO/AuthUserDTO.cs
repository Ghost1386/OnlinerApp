using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.AuthDTO;

public class AuthUserDTO
{
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}