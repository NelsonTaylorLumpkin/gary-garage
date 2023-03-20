namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla now charged to {this.BatteryKWh}KWH");
        }
    }
}