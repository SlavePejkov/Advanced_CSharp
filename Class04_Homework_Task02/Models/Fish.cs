namespace Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
