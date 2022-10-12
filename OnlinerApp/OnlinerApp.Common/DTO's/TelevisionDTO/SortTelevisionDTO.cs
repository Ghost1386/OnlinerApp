using OnlinerApp.Common.Enums.TelevisionEnum;

namespace OnlinerApp.Common.DTO_s.TelevisionDTO;

public class SortTelevisionDTO : SortBasicDTO
{
    public double ScreenSize { get; set; }

    public string Permission { get; set; }

    public TypeOf TypeOf { get; set; }

    public Platform Platform { get; set; }

    public MatrixType MatrixType { get; set; }

    public int Frequency { get; set; }
}