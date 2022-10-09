using OnlinerApp.Common.Enums.СomputerEnum;
using OperatingSystem = OnlinerApp.Common.Enums.СomputerEnum.OperatingSystem;

namespace OnlinerApp.Common.DTO_s.СomputerDTO;

public class SortСomputerDTO : SortBasicDTO
{
    public string Cpu { get; set; }
    
    public string VideoCard { get; set; }
    
    public Hdd Hdd { get; set; }
    
    public int HardDiskCapacity { get; set; }
    
    public Ram Ram { get; set; }
    
    public int RamCapacity { get; set; }
    
    public ComputerType ComputerType { get; set; }
    
    public int PowerSupply { get; set; }

    public OperatingSystem OperatingSystem { get; set; }
}