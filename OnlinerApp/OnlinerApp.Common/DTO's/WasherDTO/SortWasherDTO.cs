using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.WasherEnum;

namespace OnlinerApp.Common.DTO_s.WasherDTO;

public class SortWasherDTO : SortBasicDTO
{
    [Required]
    public string TypeOf { get; set; }
    
    [Required]
    public int Loading { get; set; }
    
    [Required]
    public DownloadMethod DownloadMethod { get; set; }
    
    [Required]
    public int SpinSpeed { get; set; }
    
    [Required]
    public string EnergyConsumption { get; set; }
    
    [Required]
    public SteamTreatment SteamTreatment { get; set; }
    
    [Required]
    public int NumberOfPrograms { get; set; }
}