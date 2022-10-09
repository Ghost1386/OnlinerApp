using OnlinerApp.Common.Enums.SortEnum;

namespace OnlinerApp.Common.DTO_s;

public class SortBasicDTO
{
    public string Manufacturer { get; set; }
    
    public int Year { get; set; }
    
    public decimal MinPrice { get; set; }
    
    public decimal MaxPrice { get; set; }

    
    public int Popularity { get; set; }
    
    public SortBy SortBy { get; set; }
}