namespace Models
{
    public static class VehicleDB
    {
        public static List<Vehicle> vehicles { get; set; } = new List<Vehicle>()
        {
            new Car { Id = 1, Type = "Sedan", YearOfProduction = 2020, BachNumber = 123, FuelTank = 50, Countries = new List<string> { "USA"} },
            new Bike { Id = 2, Type = "Sport", YearOfProduction = 2021, BachNumber = 456, Color = "Red" },
            new Vehicle { Id = 3, Type = "Truck", YearOfProduction = 2019, BachNumber = 789 }
        };




        
    } 
}
