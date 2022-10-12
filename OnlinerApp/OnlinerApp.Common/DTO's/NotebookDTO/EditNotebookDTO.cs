using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.NotebookEnum;
using OperatingSystem = OnlinerApp.Common.Enums.NotebookEnum.OperatingSystem;

namespace OnlinerApp.Common.DTO_s.NotebookDTO;

public class EditNotebookDTO : EditBasicDTO
{
    public int Diagonal { get; set; }

    public string Cpu { get; set; }

    public int Ram { get; set; }

    public string VideoCard { get; set; }

    public DriveType DriveType { get; set; }

    public int DriveCapacity { get; set; }

    public ScreenMatrix ScreenMatrix { get; set; }

    public int MatrixFrequency { get; set; }

    public OperatingSystem OperatingSystem { get; set; }
}