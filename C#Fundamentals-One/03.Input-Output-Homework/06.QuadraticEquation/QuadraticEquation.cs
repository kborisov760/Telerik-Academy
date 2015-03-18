//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic 
//equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - (4 * a * c);
        double x1, x2;
        double squareRootOfD = Math.Sqrt(d);
        x1 = (-b - squareRootOfD) / (2 * a);
        x2 = (-b + squareRootOfD) / (2 * a);

        if (d < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (d == 0)
        {
            Console.WriteLine("The equation has two equal real roots x1 = x2 = {0}", x1);
        }
        else
        {
            Console.WriteLine("x1 = {0} ; x2 = {1}", x1, x2);
        }
    }
}
