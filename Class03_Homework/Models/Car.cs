namespace Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }



        public override void PrintVehicle()
        {
            Console.WriteLine($"Car: Type: {Type}, CountriesProduced: {Countries}");
        }
    }
}
