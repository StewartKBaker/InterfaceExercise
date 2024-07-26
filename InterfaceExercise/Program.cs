using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* DONE - Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* DONE - Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* DONE - Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */
                var myCar = new Car() { Make = "Lexus", Model = "ES300h", Year = "2023", Mileage = 26, HasTrunk = true, IsTwoSeater = false, Logo = "Lexus", Slogan = "The Pursuit of Perfection"};
                var myTruck = new Truck() { Make = "Toyota", Model = "Tacoma", Year = "2017", Mileage = 21, Logo = "Toyota", Slogan = "Let's Go Places", HasHitch = true, IsOffRoad = true,};
                var mySuv = new SUV() { Make = "Mercedes-Benz", Model = "GLE-350", Year = "2024", Mileage = 29, Logo = "Mercedes", Slogan = "The best, or nothing", HasSlidingDoor = false, NumberOfDoors = 4};
                //Now, create objects of your 3 classes and give their members values.
                //Creatively display and organize their values

                //Option for displaying values: 
                //-Create a stubbed out method called DisplayDetails in your IVehicle interface.
                //-Implement the stubbed out method in the derived classes.
                //In the scope of the method, use string interpolation to display property values.
                //In order to also interpolate values from ICompany, research how to extend interfaces.
                Console.WriteLine("-----------------------------------");
                myCar.DisplayDetials();
                myTruck.DisplayDetials();
                mySuv.DisplayDetials();
        }
    }
}
