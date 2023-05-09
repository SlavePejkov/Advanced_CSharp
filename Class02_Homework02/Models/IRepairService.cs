namespace Models
{
    public interface IRepairService
    {
        public void CheckVehicle(Vehicle vehicle);
        public void FixVehicle(Vehicle vehicle);
    }
}
