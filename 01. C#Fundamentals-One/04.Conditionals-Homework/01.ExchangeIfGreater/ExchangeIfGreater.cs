//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges 
//their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        double temp = b;
        
        if (a > b)
        {
            b = a;
            a = temp;
        }

        Console.WriteLine("A -> {0} || B -> {1}", a, b);
    }
}
