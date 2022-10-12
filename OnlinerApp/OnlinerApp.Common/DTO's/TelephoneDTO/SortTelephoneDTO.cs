using OnlinerApp.Common.Enums.TelephoneEnum;
using OperatingSystem = OnlinerApp.Common.Enums.TelephoneEnum.TelephoneOperatingSystem;

namespace OnlinerApp.Common.DTO_s.TelephoneDTO;

public class SortTelephoneDTO : SortBasicDTO
{
    public int Ram { get; set; }

    public int BuiltInMemory { get; set; }

    public double ScreenSize { get; set; }

    public OperatingSystem OperatingSystem { get; set; }

    public int BatteryCapacity { get; set; }

    public TypeOfTelephone TypeOf { get; set; }

    public string CaseColor { get; set; }
}