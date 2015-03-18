//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Linq;
class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by a space: ");
        double[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
        Console.WriteLine("The sum is {0}", numbers.Sum());
    }
}
