namespace OnlinerApp.Model.Models;

public class Telephone : BasicInfo
{
    public int Id { get; set; }

    public int Ram { get; set; }
    
    public int BuiltInMemory { get; set; }
    
    public double ScreenSize { get; set; }
    
    public int OperatingSystem { get; set; }
    
    public int BatteryCapacity { get; set; }
    
    public int TypeOf { get; set; }
    
    public string CaseColor { get; set; }
}