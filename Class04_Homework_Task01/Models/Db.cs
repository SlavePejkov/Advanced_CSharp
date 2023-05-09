namespace Models
{
    public class Db <T> where T : Shape
    {
        private List<T> shapes = new List<T>();

        public void AddShape(T shape)
        {
            shapes.Add(shape);
        }

        public void PrintAreas()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape ID: {shape.Id}, Area: {shape.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape ID: {shape.Id}, Perimeter: {shape.GetPerimeter()}");
            }
        }
    }
}
