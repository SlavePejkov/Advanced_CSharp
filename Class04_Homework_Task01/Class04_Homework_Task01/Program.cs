using Models;

namespace Class04_Homework_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Db<Shape> db = new Db<Shape>();
            Circle circle = new Circle { Id = 1, Radius = 5 };
            Rectangle rectangle = new Rectangle { Id = 2, SideA = 3, SideB = 4 };

            db.AddShape(circle);
            db.AddShape(rectangle);

            db.PrintAreas();
            db.PrintPerimeters();

            circle.PrintInfo();
            rectangle.PrintInfo();
        }
    }
}