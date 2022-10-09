using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.MicrowaveEnum;

namespace OnlinerApp.Common.DTO_s.MicrowaveDTO;

public class SortMicrowaveDTO : SortBasicDTO
{
    public Execution Execution { get; set; }

    public TypeMicrowave TypeMicrowave { get; set; }

    public int Volume { get; set; }

    public Control Control { get; set; }
    
    public DoorDesign DoorDesign { get; set; }
    
    public int Power { get; set; }
    
    public RotaryTable RotaryTable { get; set; }
}