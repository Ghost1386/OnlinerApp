using System.ComponentModel.DataAnnotations;

namespace OnlinerApp.Common.DTO_s;

public class EditBasicDTO
{
    public string Manufacturer { get; set; }
    
    public int Year { get; set; }
    
    public decimal Price { get; set; }
    
    public int Popularity { get; set; }
}