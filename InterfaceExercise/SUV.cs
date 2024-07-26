using System;

namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public int NumberOfDoors { get; set; }
    public bool HasSlidingDoor { get; set; }
    
    public double Mileage { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Make { get; set; }
    public void DisplayDetials()
    {
        Console.WriteLine($"{Year} {Make} {Model}, {Mileage} MPG \nNumber of doors: {NumberOfDoors} \nHas a sliding door: {HasSlidingDoor} \n\n{Logo}, \"{Slogan}\"");
        Console.WriteLine("-----------------------------------");
    }

    public string Logo { get; set; }
    public string Slogan { get; set; }
}