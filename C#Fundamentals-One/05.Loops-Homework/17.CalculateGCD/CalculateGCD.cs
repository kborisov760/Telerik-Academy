//Problem 17.* Calculate GCD

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).


using System;
class CalculateGCD
{
    public static int GreatestCommonDivisor(int a, int b) //with recursion
    {
        if (a < 0 || b < 0)
        {
            return Math.Max(a, b);
        }

        if (a == 0)
        {
            return b;
        }

        if (b == 0)
        {
            return a;
        }

        if (a > b)
        {
            return GreatestCommonDivisor(a % b, b);
        }

        else
        {
            return GreatestCommonDivisor(a, b % a);
        }
            
    }

    static void Main()
    {
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("The greatest common divisor of {0} and {1} is {2}", a, b, GreatestCommonDivisor(a, b));
    }
}