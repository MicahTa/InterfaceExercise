using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            Car ranger = new Car {NetWorth = 8000, AveragePrice = 1100, CanDrift = true, HasSunRoof = false, MaxSpeed = 95, MilesPerGallon = 13, NumberOfEmployees = 1, Weight = .5,};
            Truck semi = new Truck {NetWorth = 100_000, AveragePrice = 150000, MaxSpeed = 110, MilesPerGallon = 5, NumberOfEmployees = 1000, Weight = 15, PermanentlyAffixedTrailer = false, TrailerAttached = true};
            SUV presidentialLimo = new SUV {NetWorth = 1_000_000_000, AveragePrice = 1_000_000, MaxSpeed = 150, MilesPerGallon = 5, NumberOfEmployees = 38, Weight = 5, HasTurrets=true, Presidential=true};

            Console.WriteLine($"This car has made this company ${ranger.NetWorth}, it comes in with an average price of ${ranger.AveragePrice} it {(ranger.CanDrift ? "can" : "cannot")} drift, it {(ranger.HasSunRoof ? "does" : "does not")} have a sun roof, it has a max speed of {ranger.MaxSpeed} mph, it gets {ranger.MilesPerGallon} mpg the company has {ranger.NumberOfEmployees} employee and it weights {ranger.Weight} tons!");
            Console.WriteLine($"This Truck has made this company ${semi.NetWorth}, it comes in with an average price of ${semi.AveragePrice} it {(semi.PermanentlyAffixedTrailer ? "does" : "does not")} have a perminatley affixed tailer, it {(semi.TrailerAttached ? "does" : "does not")} have a trailer already attached, it has a max speed of {semi.MaxSpeed} mph, it gets {semi.MilesPerGallon} mpg the company has {semi.NumberOfEmployees} employee and it weights {semi.Weight} tons!");
            Console.WriteLine($"This SUV has made this company ${presidentialLimo.NetWorth}, it comes in with an average price of ${presidentialLimo.AveragePrice} it {(presidentialLimo.HasTurrets ? "does" : "does not")} have turrets, it {(presidentialLimo.Presidential ? "is" : "is not")} presidential, it has a max speed of {presidentialLimo.MaxSpeed} mph, it gets {presidentialLimo.MilesPerGallon} mpg the company has {presidentialLimo.NumberOfEmployees} employee and it weights {presidentialLimo.Weight} tons!");




            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
