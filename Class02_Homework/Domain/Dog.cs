namespace Domain
{
    public class Dog : Animal, IDog
    {
       public Dog(string name, int age) : base(name, age)
        {

        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"This is a  dog and hes name is {Name} and hes {Age} years old");
        }
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
}
