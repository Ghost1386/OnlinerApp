using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.UserDTO;

public class EditUserDTO
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