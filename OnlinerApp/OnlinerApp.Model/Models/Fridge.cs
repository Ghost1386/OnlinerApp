namespace OnlinerApp.Model.Models;

public class Fridge : BasicModel
{
    public int Id { get; set; }
    
    public int Execution { get; set; }
    
    public double Height { get; set; }
    
    public double Width { get; set; }
    
    public string EnergyClass { get; set; }
    
    public string Modes { get; set; }
    
    public string Peculiarities { get; set; }
}