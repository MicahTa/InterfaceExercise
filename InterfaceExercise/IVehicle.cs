using System;

namespace InterfaceExercise
{
    public interface IVehicle {
        public double weight { get; set; }
        public int maxSpeed { get; set; }
        public int milesPerGallon { get; set; }
        public int averagePrice { get; set; }
    }
}