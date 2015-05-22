//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
class PrimeNumbers
{
    private static bool IsPrimeNumber(int number)
    {
        if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            return true;
        }
        if (number == 1)
        {
            return false;
        }
        if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main()
    {
        bool[] numbers = new bool[100];
        int[] realNumbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
            realNumbers[i] = i + 1;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (!IsPrimeNumber(realNumbers[i]))
            {
                numbers[i] = false;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Is {0} prime? --> {1}",realNumbers[i], numbers[i]);
        }
    }
}
