using System;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    public bool IsOffRoad { get; set; }
    public bool HasHitch { get; set; }
    
    public double Mileage { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public void DisplayDetials()
    {
        Console.WriteLine($"{Year} {Make} {Model}, {Mileage} MPG \nOff-Road Drive: {IsOffRoad} \nHas Hitch: {HasHitch} \n\n{Logo}, \"{Slogan}\"");
        Console.WriteLine("-----------------------------------");
    }
    public string Logo { get; set; }
    public string Slogan { get; set; }
}