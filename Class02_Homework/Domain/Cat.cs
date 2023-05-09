namespace Domain
{
    public class Cat : Animal, ICat
    {

        public Cat(string name, int age) : base(name, age)
        {

        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"This is a cat and hes name is {Name}");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}");
        }
    }
}
