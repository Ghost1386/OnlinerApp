namespace OnlinerApp.Model.Models;

public class VacuumCleaner : BasicModel
{
    public int Id { get; set; }
    
    public string TypeOf { get; set; }
    
    public string Supply { get; set; }
    
    public int SuctionPower { get; set; }
    
    public int PowerAdjustment { get; set; }
    
    public int Pipe { get; set; }
}