namespace Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checking the vehicle");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing the vehicle");
        }
    }
}
