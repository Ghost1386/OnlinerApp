using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.UserDTO;

public class DeleteUserDTO
{
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}