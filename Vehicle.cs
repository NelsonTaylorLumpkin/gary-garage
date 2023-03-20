namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The car isn't moving anymore.");
        }
    }
}