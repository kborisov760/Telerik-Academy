//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that 
//is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
class FirstLargerThanNeighbours
{
    static int CheckFirstNumberIfLarger(int[] numbers)
    {
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        Console.Write("Array length: ");
        int n = int.Parse(Console.ReadLine());
        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(CheckFirstNumberIfLarger(numbers));
    }
}