using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.MicrowaveEnum;

namespace OnlinerApp.Common.DTO_s.MicrowaveDTO;

public class EditMicrowaveDTO : EditBasicDTO
{
    [Required]
    public Execution Execution { get; set; }
    
    [Required]
    public TypeMicrowave TypeMicrowave { get; set; }
    
    [Required]
    public int Volume { get; set; }
    
    [Required]
    public Control Control { get; set; }
    
    [Required]
    public DoorDesign DoorDesign { get; set; }
    
    [Required]
    public int Power { get; set; }
    
    [Required]
    public RotaryTable RotaryTable { get; set; }
}