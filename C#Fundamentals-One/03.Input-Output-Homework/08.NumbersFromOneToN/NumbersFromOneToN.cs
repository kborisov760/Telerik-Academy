//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;
class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Position [{0}] --> {1}", i, i);
        }
        Console.WriteLine("-------------------------");
    }
}
