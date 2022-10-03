namespace OnlinerApp.Model.Models;

public class Fridge : BasicInfo
{
    public int Id { get; set; }
    
    public string Execution { get; set; }
    
    public double Height { get; set; }
    
    public double Width { get; set; }
    
    public int EnergyClass { get; set; }
    
    public string Modes { get; set; }
    
    public string Peculiarities { get; set; }
}