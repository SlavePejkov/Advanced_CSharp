using Domain;

namespace Class02_Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dog dog1 = new Dog("Max", 5);
            dog1.PrintAnimal();
            dog1.Bark();

            Cat cat1 = new Cat("Kitty", 5);
            cat1.PrintAnimal();
            cat1.Eat("fish");
            
        }
    }
}