using OnlinerApp.Common.Enums.WasherEnum;

namespace OnlinerApp.Common.DTO_s.WasherDTO;

public class EditWasherDTO : EditBasicDTO
{
    public string TypeOf { get; set; }

    public int Loading { get; set; }

    public DownloadMethod DownloadMethod { get; set; }

    public int SpinSpeed { get; set; }

    public string EnergyConsumption { get; set; }

    public SteamTreatment SteamTreatment { get; set; }

    public int NumberOfPrograms { get; set; }
}