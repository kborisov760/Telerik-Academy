//Problem 10. N Factorial

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;
class FactorialN
{
    static BigInteger MultiplyNumberFactorial(int n)
    {
        BigInteger result = 1;
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
            result *= numbers[i];
        }

        return result;
    }
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial of {0} is --> {1}", n, MultiplyNumberFactorial(n));
    }
}