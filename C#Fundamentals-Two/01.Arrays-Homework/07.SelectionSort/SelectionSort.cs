//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
//smallest from the rest, move it at the second position, etc.

using System;
using System.IO;
using System.Collections.Generic;
class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array length:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int len = numbers.Length;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Elemnt[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < len; i++)
        {
            int minPos = i; //position of the smallest number
            int minNumber = numbers[i]; //value of the number
            for (int j = i; j < len; j++)
            {
                if (numbers[j] < minNumber)
                {
                    minPos = j;
                    minNumber = numbers[j];
                }
            }
            int swap = numbers[minPos]; //swap values
            numbers[minPos] = numbers[i];
            numbers[i] = swap;
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}