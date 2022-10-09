using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.FridgeEnum;

namespace OnlinerApp.Common.DTO_s.FridgeDTO;

public class SortFridgeDTO : SortBasicDTO
{
    public Execution Execution { get; set; }
    
    public double Height { get; set; }
    
    public double Width { get; set; }
    
    public string EnergyClass { get; set; }
    
    public string Modes { get; set; }
    
    public string Peculiarities { get; set; }
}