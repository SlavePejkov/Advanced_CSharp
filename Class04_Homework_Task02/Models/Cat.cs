namespace Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} {Type} {Age} {Lazy} {LivesLeft}");
        }
    }
}
