using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.HobEnum;

namespace OnlinerApp.Common.DTO_s.HobDTO;

public class SortHobDTO : SortBasicDTO
{
    [Required]
    public string TypeOf { get; set; }
    
    [Required]
    public int NumberOfBurners { get; set; }
    
    [Required]
    public string Color { get; set; }
    
    [Required]
    public Lattices Lattices { get; set; }
    
    [Required]
    public WorkingSurface WorkingSurface { get; set; }
    
    [Required]
    public ElectricIgnition ElectricIgnition { get; set; }
    
    [Required]
    public AutomaticBoiling AutomaticBoiling { get; set; }
}