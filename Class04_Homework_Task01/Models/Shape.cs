namespace Models
{
    public class Shape
    {
        public int Id { get; set; }

        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }

       
    }
}
