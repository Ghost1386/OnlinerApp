using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.TelevisionEnum;

namespace OnlinerApp.Common.DTO_s.TelevisionDTO;

public class EditTelevisionDTO : EditBasicDTO
{
    [Required]
    public double ScreenSize { get; set; }
    
    [Required]
    public string Permission { get; set; }
    
    [Required]
    public TypeOf TypeOf { get; set; }
    
    [Required]
    public Platform Platform { get; set; }
    
    [Required]
    public MatrixType MatrixType { get; set; }
    
    [Required]
    public int Frequency { get; set; }
}