namespace Models
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine("Washing the Car");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing the truck");
        }

    }
}
