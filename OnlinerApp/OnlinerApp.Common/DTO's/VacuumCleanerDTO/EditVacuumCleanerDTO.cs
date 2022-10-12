using OnlinerApp.Common.Enums.VacuumCleanerEnum;

namespace OnlinerApp.Common.DTO_s.VacuumCleanerDTO;

public class EditVacuumCleanerDTO : EditBasicDTO
{
    public string TypeOf { get; set; }

    public string Supply { get; set; }

    public int SuctionPower { get; set; }

    public PowerAdjustment PowerAdjustment { get; set; }

    public Pipe Pipe { get; set; }
}