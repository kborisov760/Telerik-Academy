//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
class PerimeterAndAreaCircle
{
    static void Main()
    {
        Console.Write("Enter radius (r) of the circle: ");
        double r = double.Parse(Console.ReadLine());
        double circlePerimeter = Math.Round(2 * Math.PI * r, 2);
        double circleArea = Math.Round(Math.PI * Math.Pow(r, 2), 2);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Perimeter = {0}", circlePerimeter);
        Console.WriteLine("Area = {0}", circleArea);
        Console.WriteLine("--------------------------");
    }
}
