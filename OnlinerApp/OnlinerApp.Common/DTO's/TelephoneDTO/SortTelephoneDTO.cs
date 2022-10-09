using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.TelephoneEnum;
using OperatingSystem = OnlinerApp.Common.Enums.TelephoneEnum.OperatingSystem;

namespace OnlinerApp.Common.DTO_s.TelephoneDTO;

public class SortTelephoneDTO : SortBasicDTO
{
    [Required]
    public int Ram { get; set; }
    
    [Required]
    public int BuiltInMemory { get; set; }
    
    [Required]
    public double ScreenSize { get; set; }
    
    [Required]
    public OperatingSystem OperatingSystem { get; set; }
    
    [Required]
    public int BatteryCapacity { get; set; }
    
    [Required]
    public TypeOf TypeOf { get; set; }
    
    [Required]
    public string CaseColor { get; set; }
}