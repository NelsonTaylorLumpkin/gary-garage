using System;

namespace Garage
{
    public class Ram  : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"Your Ram is gassed up to {this.FuelCapacity} gallons");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram is ready to do a really tough job!");
        }
    }
}