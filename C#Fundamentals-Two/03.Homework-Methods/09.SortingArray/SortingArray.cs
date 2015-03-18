//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;

class SortingArray
{
    static void SelectionSort(int[] numbers)
    {
        int len = numbers.Length;

        for (int i = 0; i < len; i++)
        {
            int minPos = i;
            int minNumber = numbers[i];
            for (int j = i; j < len; j++)
            {
                if (numbers[j] < minNumber)
                {
                    minPos = j;
                    minNumber = numbers[j];
                }
            }
            int swap = numbers[minPos];
            numbers[minPos] = numbers[i];
            numbers[i] = swap;
        }
    }

    static int ReturnMaximalElementInArray(int[] numbers, int index)
    {
        int[] copyNumbers = new int[numbers.Length - index];
        for (int i = 0; i < numbers.Length - index; i++)
        {
            copyNumbers[i] = numbers[i + index];
        }
        SelectionSort(copyNumbers);
        int maxElem = copyNumbers[copyNumbers.Length - 1];
        return maxElem;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter array length:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter index of the element:");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine(ReturnMaximalElementInArray(numbers, index));
    }
}
