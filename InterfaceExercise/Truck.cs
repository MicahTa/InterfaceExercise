using System;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle {
        public int netWorth { get; set; }
        public int numberOfEmployees { get; set; }

        public double weight { get; set; }
        public int maxSpeed { get; set; }
        public int milesPerGallon { get; set; }
        public int averagePrice { get; set; }


        public bool trailerAttached { get; set; }
        public bool perminatleyAffixedTrailer { get; set; }
    }
}