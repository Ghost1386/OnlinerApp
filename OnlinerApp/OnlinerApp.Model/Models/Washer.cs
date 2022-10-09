namespace OnlinerApp.Model.Models;

public class Washer : BasicModel
{
    public int Id { get; set; }
    
    public string TypeOf { get; set; }
    
    public int Loading { get; set; }
    
    public int DownloadMethod { get; set; }
    
    public int SpinSpeed { get; set; }
    
    public string EnergyConsumption { get; set; }
    
    public int SteamTreatment { get; set; }
    
    public int NumberOfPrograms { get; set; }
}