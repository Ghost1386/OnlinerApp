using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.VacuumCleanerEnum;

namespace OnlinerApp.Common.DTO_s.VacuumCleanerDTO;

public class EditVacuumCleanerDTO : EditBasicDTO
{
    [Required]
    public string TypeOf { get; set; }
    
    [Required]
    public string Supply { get; set; }
    
    [Required]
    public int SuctionPower { get; set; }
    
    [Required]
    public PowerAdjustment PowerAdjustment { get; set; }
    
    [Required]
    public Pipe Pipe { get; set; }
}