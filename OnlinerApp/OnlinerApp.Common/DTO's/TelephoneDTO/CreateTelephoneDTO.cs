using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.TelephoneEnum;
using OperatingSystem = OnlinerApp.Common.Enums.TelephoneEnum.TelephoneOperatingSystem;

namespace OnlinerApp.Common.DTO_s.TelephoneDTO;

public class CreateTelephoneDTO : CreateBasicDTO
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
    public TypeOfTelephone TypeOf { get; set; }
    
    [Required]
    public string CaseColor { get; set; }
}