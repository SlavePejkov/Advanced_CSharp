namespace Models
{
    public class CarCenter : ICarWash, IRepairService, IGasPump
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("Washing Car");
        }
        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Washing Truck");
        }

        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checking vehicle");
        }
        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing Vehicle");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Pumping Gas in the vehicle");
        }
    }
}
