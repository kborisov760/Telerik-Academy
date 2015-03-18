//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
class CalculateSecond
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        double result = 0;
        double factorialForN = 1;
        double factorialForK = 1;

        while (n > 1)
        {
            if (k == 1)
            {
                factorialForN *= n;
                n--;
            }
            else
            {
                factorialForN *= n;
                factorialForK *= k;
                n--;
                k--;
            }
            
        }

        result = factorialForN / factorialForK;

        Console.WriteLine("--------------------");
        Console.WriteLine("The result is {0}", result);
        Console.WriteLine("--------------------"); 
    }
}
