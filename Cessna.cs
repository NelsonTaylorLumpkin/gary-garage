using System;
namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle// Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }
      

        public void RefuelTank()
        {
             CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine("Zooooooom!");
        }
    }
}