using System;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle  {
        public int NetWorth { get; set; }
        public int NumberOfEmployees { get; set; }

        public double Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int MilesPerGallon { get; set; }
        public int AveragePrice { get; set; }

        public bool Presidential { get; set; }
        public bool HasTurrets { get; set; }
    }
}