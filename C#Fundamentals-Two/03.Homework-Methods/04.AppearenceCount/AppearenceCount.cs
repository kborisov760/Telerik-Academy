//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
class AppearenceCount
{
    static int ReturnNumberCountAppearance(int[] numbers, int givenNumber)
    {
        var list = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == givenNumber)
            {
                list.Add(numbers[i]);
            }
        }

        return list.Count;
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
        Console.Write("Enter existing element you want to count: ");
        int elementToCount = int.Parse(Console.ReadLine());
        Console.WriteLine("The element {0} appears {1} time(s).", elementToCount, ReturnNumberCountAppearance(numbers, elementToCount));
    }
}
