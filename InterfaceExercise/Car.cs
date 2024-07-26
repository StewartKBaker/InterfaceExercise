using System;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
    public bool HasTrunk { get; set; }
    public bool IsTwoSeater { get; set; }
    
    public double Mileage { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }

    public string Logo { get; set; }
    public string Slogan { get; set; }

    public void DisplayDetials()
    {
        Console.WriteLine($"{Year} {Make} {Model}, {Mileage} MPG \nHas 2 Seats ONLY: {IsTwoSeater} \nHas Trunk: {HasTrunk} \n\n{Logo}, \"{Slogan}\"");
        Console.WriteLine("-----------------------------------");
    }
}