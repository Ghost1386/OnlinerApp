using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.MotorbikeEnum;

namespace OnlinerApp.Common.DTO_s.MotorbikeDTO;

public class SortMotorbikeDTO : SortBasicDTO
{
    [Required]
    public string TypeOf { get; set; }
    
    [Required]
    public int Volume { get; set; }
    
    [Required]
    public int NumberOfCylinders { get; set; }
    
    [Required]
    public int Power { get; set; }
    
    [Required]
    public Cooling Cooling { get; set; }
    
    [Required]
    public double FuelConsumption { get; set; }
    
    [Required]
    public ElectricStarter ElectricStarter { get; set; }
}