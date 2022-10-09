using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.HobEnum;

namespace OnlinerApp.Common.DTO_s.HobDTO;

public class SortHobDTO : SortBasicDTO
{
    public string TypeOf { get; set; }
    
    public int NumberOfBurners { get; set; }
    
    public string Color { get; set; }
    
    public Lattices Lattices { get; set; }
    
    public WorkingSurface WorkingSurface { get; set; }
    
    public ElectricIgnition ElectricIgnition { get; set; }
    
    public AutomaticBoiling AutomaticBoiling { get; set; }
}