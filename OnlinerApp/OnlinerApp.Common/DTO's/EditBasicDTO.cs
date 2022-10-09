using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s;

public class EditBasicDTO
{
    [Required]
    public string Manufacturer { get; set; }
    
    [Required]
    public int Year { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public int Popularity { get; set; }
}