using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.СomputerEnum;
using OperatingSystem = OnlinerApp.Common.Enums.NotebookEnum.OperatingSystem;

namespace OnlinerApp.Common.DTO_s.СomputerDTO;

public class CreateСomputerDTO : CreateBasicDTO
{
    [Required]
    public string Cpu { get; set; }
    
    [Required]
    public string VideoCard { get; set; }
    
    [Required]
    public Hdd Hdd { get; set; }
    
    [Required]
    public int HardDiskCapacity { get; set; }
    
    [Required]
    public Ram Ram { get; set; }
    
    [Required]
    public int RamCapacity { get; set; }
    
    [Required]
    public ComputerType ComputerType { get; set; }
    
    [Required]
    public int PowerSupply { get; set; }
    
    [Required]
    public OperatingSystem OperatingSystem { get; set; }
}