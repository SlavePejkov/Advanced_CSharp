namespace Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike: YearOfProduction: {YearOfProduction}, Color: {Color}");
        }
    }
}
