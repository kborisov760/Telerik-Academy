namespace Shapes
{
    using System;
    using Classes;
    public class ShapesTest
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(2.5m, 5.4m);
            Triangle triangle = new Triangle(6, 3);
            Square square = new Square(7, 7);
            Console.WriteLine("-------------------");
            Console.WriteLine("Rectangle surface: {0}", rectangle.CalculateSurface());
            Console.WriteLine("Triangle surface: {0}", triangle.CalculateSurface());
            Console.WriteLine("Square surface: {0}", square.CalculateSurface());
            Console.WriteLine("-------------------");
        }
    }
}
