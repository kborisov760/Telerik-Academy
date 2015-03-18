//Problem 18.* Trailing Zeroes in N!

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;
class TrailingZeroesInN
{
    static void Main() //Program works correct, but for very big number there is need for more time. 
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        string zeroCounter = string.Empty;
        int counter = 0;
        while (n > 1)
        {
            factorialN *= n;
            n--;
        }

        zeroCounter = factorialN.ToString();
        
        for (int i = 0; i < zeroCounter.Length; i++)
        {
            if (zeroCounter[zeroCounter.Length - i - 1] != '0')
            {
                break;
            }
            else
            {
                counter++;
            }
        }

        Console.WriteLine("Trailing zeroes of n!: {0}", counter);
    }
}