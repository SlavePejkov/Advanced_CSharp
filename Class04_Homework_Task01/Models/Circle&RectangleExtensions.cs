namespace Models
{
    public static class Circle_RectangleExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle with ID {circle.Id} and radius {circle.Radius} has area {circle.GetArea()} and perimeter {circle.GetPerimeter()}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with ID {rectangle.Id} and sides {rectangle.SideA} and {rectangle.SideB} has area {rectangle.GetArea()} and perimeter {rectangle.GetPerimeter()}");
        }
    }
}
