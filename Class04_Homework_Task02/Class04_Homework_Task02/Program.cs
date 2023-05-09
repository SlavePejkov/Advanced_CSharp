using Models;
namespace Class04_Homework_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog { Name = "Rex", Type = "Golden Retriever", Age = 3, FavoriteFood = "Bones" };
            Dog dog2 = new Dog { Name = "Max", Type = "German Shepherd", Age = 2, FavoriteFood = "Steak" };
            List<Dog> dogs = new List<Dog> { dog1, dog2 };
            PetStore<Dog> dogStore = new PetStore<Dog>(dogs);

            Cat cat1 = new Cat { Name = "Kitty", Type = "Black", Age = 5, Lazy = true, LivesLeft = 7 };
            Cat cat2 = new Cat { Name = "Simba", Type = "Brown", Age = 4, Lazy = false, LivesLeft = 9 };
            List<Cat> cats = new List<Cat> { cat1, cat2 };
            PetStore<Cat> catStore = new PetStore<Cat>(cats);

            Fish fish1 = new Fish { Name = "Dorie", Type = "Bluefish", Age = 1, Color = "Gold", Size = "Small" };
            Fish fish2 = new Fish { Name = "Nemo", Type = "Clownfish", Age = 2, Color = "Orange", Size = "Small" };
            List<Fish> fish = new List<Fish> { fish1, fish2 };

            Console.WriteLine("Dog Store:");
            dogStore.PrintPets();

            Console.WriteLine("\nCat Store:");
            catStore.PrintPets();

            dogStore.BuyPet("Edie");
            catStore.BuyPet("Simba");
        }
    }
}