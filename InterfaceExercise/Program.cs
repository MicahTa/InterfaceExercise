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
            
            Car ranger = new Car {netWorth = 8000, averagePrice = 1100, canDrift = true, hasSunRoof = false, maxSpeed = 95, milesPerGallon = 13, numberOfEmployees = 1, weight = .5,};
            Truck semi = new Truck {netWorth = 100_000, averagePrice = 150000, maxSpeed = 110, milesPerGallon = 5, numberOfEmployees = 1000, weight = 15, perminatleyAffixedTrailer = false, trailerAttached = true};
            SUV presidentialLimo = new SUV {netWorth = 1_000_000_000, averagePrice = 1_000_000, maxSpeed = 150, milesPerGallon = 5, numberOfEmployees = 38, weight = 5, hasTurrets=true, presidential=true};

            Console.WriteLine($"This car has made this company ${ranger.netWorth}, it comes in with an average price of ${ranger.averagePrice} it {(ranger.canDrift ? "can" : "cannot")} drift, it {(ranger.hasSunRoof ? "does" : "does not")} have a sun roof, it has a max speed of {ranger.maxSpeed} mph, it gets {ranger.milesPerGallon} mpg the company has {ranger.numberOfEmployees} employee and it weights {ranger.weight} tons!");
            Console.WriteLine($"This Truck has made this company ${semi.netWorth}, it comes in with an average price of ${semi.averagePrice} it {(semi.perminatleyAffixedTrailer ? "does" : "does not")} have a perminatley affixed tailer, it {(semi.trailerAttached ? "does" : "does not")} have a trailer already attached, it has a max speed of {semi.maxSpeed} mph, it gets {semi.milesPerGallon} mpg the company has {semi.numberOfEmployees} employee and it weights {semi.weight} tons!");
            Console.WriteLine($"This SUV has made this company ${presidentialLimo.netWorth}, it comes in with an average price of ${presidentialLimo.averagePrice} it {(presidentialLimo.hasTurrets ? "does" : "does not")} have turrrets, it {(presidentialLimo.presidential ? "is" : "is not")} presidential, it has a max speed of {presidentialLimo.maxSpeed} mph, it gets {presidentialLimo.milesPerGallon} mpg the company has {presidentialLimo.numberOfEmployees} employee and it weights {presidentialLimo.weight} tons!");




            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
