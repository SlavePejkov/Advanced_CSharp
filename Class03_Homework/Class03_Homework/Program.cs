using Models;
namespace Class03_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var vehicle in VehicleDB.vehicles)
            {
                vehicle.PrintVehicle();
            }

            var car1 = new Car { Id = 4, Type = "Jeep", YearOfProduction = 2022, BachNumber = 234, FuelTank = 60, Countries = new List<string> { "Germany" } };
            var bike1 = new Bike { Id = 5, Type = "Cross", YearOfProduction = 2023, BachNumber = 567, Color = "Blue" };

            Console.WriteLine($"Car1 validation result: {Validator.Validate((Vehicle)car1)}");
            Console.WriteLine($"Bike1 validation result: {Validator.Validate((Vehicle)bike1)}");
        }
    }
    
}