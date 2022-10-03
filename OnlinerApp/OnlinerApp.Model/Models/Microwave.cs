﻿namespace OnlinerApp.Model.Models;

public class Microwave : BasicInfo
{
    public int Id { get; set; }
    
    public int Execution { get; set; }
    
    public int TypeOf { get; set; }
    
    public int Volume { get; set; }
    
    public int Control { get; set; }
    
    public int DoorDesign { get; set; }
    
    public int MicrowavePower { get; set; }
    
    public int RotaryTable { get; set; }
}