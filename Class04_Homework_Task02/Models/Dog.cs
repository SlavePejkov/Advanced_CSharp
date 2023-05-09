namespace Models
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Type} {Age} {FavoriteFood}");
        }
    }
}
