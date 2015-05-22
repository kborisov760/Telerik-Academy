//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(numbers);

        int index = Array.BinarySearch(numbers, k);
        int myNumber = numbers[index - 1];

        Console.WriteLine("The biggest element N <= {0} is {1}", k, myNumber);
    }
}
