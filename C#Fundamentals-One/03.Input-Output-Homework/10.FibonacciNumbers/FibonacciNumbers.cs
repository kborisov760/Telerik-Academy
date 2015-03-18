//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members 
//of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger[] fibonacciNumber = new BigInteger[Math.Max(n, 3)];
        
        if (n < 1)
        {
            Console.WriteLine("No numbers to show!");
        }

        else if (n == 1)
        {
            Console.WriteLine(0);
        }

        else
        {
            fibonacciNumber[0] = 0;
            fibonacciNumber[1] = 1;
            fibonacciNumber[2] = 1;

            for (int i = 3; i < fibonacciNumber.Length; i++)
            {
                fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];
            }

            Console.WriteLine(string.Join(", ", fibonacciNumber));
        }
        
    }
}
