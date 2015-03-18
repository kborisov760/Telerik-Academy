//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class TrapezoidArea
{
    private static double CalculateTrapezoidArea(double a, double b, double h)
    {
        double area = ((a + b) / 2) * h;
        return area;
       
    }
    static void Main()
    {
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid area equals to {0}.", CalculateTrapezoidArea(a, b, h));
    }
}
