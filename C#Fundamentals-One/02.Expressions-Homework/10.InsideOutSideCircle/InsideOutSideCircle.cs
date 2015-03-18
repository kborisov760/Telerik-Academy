//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;  
class InsideOutSideCircle
{
    static void Main()
    {
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());

        string outstring = (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2)) && (x <= 2.5 && x >= -0.5) && (y <= 2.5 && y > 1) ? "Yes!" : "No!";

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("The point is in the circle and outside of a rectangle? --> {0}", outstring);
        Console.WriteLine("---------------------------------------------------------------");
    }
}