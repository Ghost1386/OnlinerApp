namespace OnlinerApp.Model.Models;

public class Motorbike : BasicModel
{
    public int Id { get; set; }
    
    public string TypeOf { get; set; }
    
    public int Volume { get; set; }
    
    public int NumberOfCylinders { get; set; }
    
    public int Power { get; set; }
    
    public int Cooling { get; set; }
    
    public double FuelConsumption { get; set; }
    
    public int ElectricStarter { get; set; }
}