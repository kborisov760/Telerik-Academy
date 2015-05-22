//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());

        string outstring = (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(2, 2)) ? "True" : "False";

        Console.WriteLine("Is in the circle? {0}", outstring);
    }
}
