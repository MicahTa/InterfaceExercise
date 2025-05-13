using System;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle {
        public int NetWorth { get; set; }
        public int NumberOfEmployees { get; set; }

        public double Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int MilesPerGallon { get; set; }
        public int AveragePrice { get; set; }


        public bool TrailerAttached { get; set; }
        public bool PermanentlyAffixedTrailer { get; set; }
    }
}