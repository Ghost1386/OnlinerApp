using System.ComponentModel.DataAnnotations;
using OnlinerApp.Common.Enums.MotorbikeEnum;

namespace OnlinerApp.Common.DTO_s.MotorbikeDTO;

public class SortMotorbikeDTO : SortBasicDTO
{
    public string TypeOf { get; set; }

    public int Volume { get; set; }

    public int NumberOfCylinders { get; set; }

    public int Power { get; set; }

    public Cooling Cooling { get; set; }

    public double FuelConsumption { get; set; }

    public ElectricStarter ElectricStarter { get; set; }
}