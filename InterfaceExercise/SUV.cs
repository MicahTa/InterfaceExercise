using System;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle  {
        public int netWorth { get; set; }
        public int numberOfEmployees { get; set; }

        public double weight { get; set; }
        public int maxSpeed { get; set; }
        public int milesPerGallon { get; set; }
        public int averagePrice { get; set; }

        public bool presidential { get; set; }
        public bool hasTurrets { get; set; }
    }
}