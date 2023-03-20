using System;
namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("VROOM, VROOM!");
        }
     
        public override void Drive()
        {
            Console.WriteLine($"Your sad little pinto is caught in a {MainColor} Zero's flaming exhaust as it zips by you at 100000 mph");
        }
    }
}