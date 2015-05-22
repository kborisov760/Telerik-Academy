//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;
    class CalculateFirst
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            double sumOfNumber = 1;
            double currentFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                currentFactorial *= i;
                sumOfNumber += currentFactorial / Math.Pow(x, i);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("The sum is {0:0.00000}", sumOfNumber);
            Console.WriteLine("--------------------"); 
        }
    }
