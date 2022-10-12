using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.UserDTO;

public class EditUserDTO
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}