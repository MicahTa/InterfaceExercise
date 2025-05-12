using System;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle {
        public int netWorth { get; set; }
        public int numberOfEmployees { get; set; }

        public double weight { get; set; }
        public int maxSpeed { get; set; }
        public int milesPerGallon { get; set; }
        public int averagePrice { get; set; }


        public bool hasSunRoof { get; set; }
        public bool canDrift { get; set; }
    }
}