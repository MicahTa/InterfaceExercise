using System;

namespace InterfaceExercise
{
    public interface IVehicle {
        public double Weight { get; set; }
        public int MaxSpeed { get; set; }
        public int MilesPerGallon { get; set; }
        public int AveragePrice { get; set; }
    }
}