namespace Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BachNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Vehicle: Id: {Id}, Type: {Type}, YearOfProduction: {YearOfProduction}");
        }
    }
}
