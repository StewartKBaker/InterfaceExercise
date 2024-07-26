using System;

namespace InterfaceExercise;

public interface IVehicle
{
    public double Mileage { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }

    public void DisplayDetials();

}