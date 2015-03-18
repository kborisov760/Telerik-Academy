//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given 
//array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;

class LargerThanNeighbours
{
    static bool CheckIfNumberAtPositionIsBiggerThanNeighbours(int[] numbers, int index)
    {
        if (numbers[index] > numbers[index-1] && numbers[index] > numbers[index+1])
        {
            return true;
        }
        else
        {
            return false;
        }
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
        Console.Write("Enter index of element to check: ");
        int indexToCheck = int.Parse(Console.ReadLine());

        if (indexToCheck == 0 || indexToCheck == (numbers.Length - 1))
        {
            Console.WriteLine("No such elements..");
        }
        else
        {
            Console.WriteLine("Element at position {0} is larger than neighbours? --> {1}", indexToCheck, CheckIfNumberAtPositionIsBiggerThanNeighbours(numbers, indexToCheck));
        }
    }
}