namespace Domain
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void PrintAnimal();
    }
}
