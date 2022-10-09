using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.AuthDTO;

public class RegisterUserDTO
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Surname { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}