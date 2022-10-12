using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s.DeleteDTO;

public class DeleteBasicDTO
{
    [Required]
    public int Id { get; set; }
}