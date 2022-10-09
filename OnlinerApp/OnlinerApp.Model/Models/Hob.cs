namespace OnlinerApp.Model.Models;

public class Hob : BasicModel
{
    public int Id { get; set; }
    
    public string TypeOf { get; set; }
    
    public int NumberOfBurners { get; set; }
    
    public string Color { get; set; }
    
    public int Lattices { get; set; }
    
    public int WorkingSurface { get; set; }
    
    public int ElectricIgnition { get; set; }
    
    public int AutomaticBoiling { get; set; }
}