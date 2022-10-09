namespace OnlinerApp.Model.Models;

public class Notebook : BasicModel
{
    public int Id { get; set; }

    public int Diagonal { get; set; }
    
    public string Cpu { get; set; }
    
    public int Ram { get; set; }

    public string VideoCard { get; set; }
    
    public int DriveType { get; set; }
    
    public int DriveCapacity { get; set; }
    
    public int ScreenMatrix { get; set; }
    
    public int MatrixFrequency { get; set; }
    
    public int OperatingSystem { get; set; }
}