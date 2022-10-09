using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.FridgeEnum;

namespace OnlinerApp.Common.DTO_s.FridgeDTO;

public class CreateFridgeDTO : CreateBasicDTO
{
    [Required]
    public Execution Execution { get; set; }
    
    [Required]
    public double Height { get; set; }
    
    [Required]
    public double Width { get; set; }
    
    [Required]
    public string EnergyClass { get; set; }
    
    [Required]
    public string Modes { get; set; }
    
    [Required]
    public string Peculiarities { get; set; }
}