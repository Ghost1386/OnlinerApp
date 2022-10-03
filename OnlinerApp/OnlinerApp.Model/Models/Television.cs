namespace OnlinerApp.Model.Models;

public class Television : BasicInfo
{
    public int Id { get; set; }

    public double ScreenSize { get; set; }

    public string Permission { get; set; }
    
    public int TypeOf { get; set; }
    
    public int Platform { get; set; }
    
    public int MatrixType { get; set; }
    
    public int Frequency { get; set; }
}