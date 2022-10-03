namespace OnlinerApp.Model.Models;

public class Сomputer : BasicInfo
{
    public int Id { get; set; }
    
    public string Cpu { get; set; }
    
    public string VideoCard { get; set; }
    
    public int Hdd { get; set; }
    
    public int HardDiskCapacity { get; set; }
    
    public int Ram { get; set; }
    
    public int RamCapacity { get; set; }
    
    public int ComputerType { get; set; }
    
    public int PowerSupply { get; set; }
    
    public int OperatingSystem { get; set; }
}