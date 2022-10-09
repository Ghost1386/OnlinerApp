using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.NotebookEnum;
using OperatingSystem = OnlinerApp.Common.Enums.NotebookEnum.OperatingSystem;

namespace OnlinerApp.Common.DTO_s.NotebookDTO;

public class EditNotebookDTO : EditBasicDTO
{
    [Required]
    public int Diagonal { get; set; }
    
    [Required]
    public string Cpu { get; set; }
    
    [Required]
    public int Ram { get; set; }

    [Required]
    public string VideoCard { get; set; }
    
    [Required]
    public DriveType DriveType { get; set; }
    
    [Required]
    public int DriveCapacity { get; set; }
    
    [Required]
    public ScreenMatrix ScreenMatrix { get; set; }
    
    [Required]
    public int MatrixFrequency { get; set; }
    
    [Required]
    public OperatingSystem OperatingSystem { get; set; }
}