//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        double sum = 0;
        Console.WriteLine("-------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number[{0}]: ",i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine("The sum is {0}.", sum);
        Console.WriteLine("-------------------------");
    }
}
