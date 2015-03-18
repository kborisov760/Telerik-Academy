//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
class MinMaxSumAverage
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number [{0}]: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        double maxElement = numbers[numbers.Length - 1];
        double minElement = numbers[0];
        double sumOfElements = 0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            sumOfElements += numbers[i];
        }

        double averageOfElements = Math.Round((sumOfElements / n), 2);
        
        Console.WriteLine("----------");
        Console.WriteLine("Min = {0}", minElement);
        Console.WriteLine("Max = {0}", maxElement);
        Console.WriteLine("Sum = {0}", sumOfElements);
        Console.WriteLine("Avg = {0}", averageOfElements);
        Console.WriteLine("----------");
    }
}
