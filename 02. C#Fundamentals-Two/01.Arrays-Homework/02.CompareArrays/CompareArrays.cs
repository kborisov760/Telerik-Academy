//Problem 2. Compare arrays

//Write a program that reads two integer arrays 
//from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        Console.Write("First array size: ");
        int firstArrSize = int.Parse(Console.ReadLine());
        
        Console.Write("Second array size: ");
        int secondArrSize = int.Parse(Console.ReadLine());
        
        while (true)
        {
            if (firstArrSize == secondArrSize)
            {
                break;
            }
            else
            {
                Console.WriteLine("Two arrays cannot have different sizes. Please enter equal numbers!");
                Console.Write("First array size: ");
                firstArrSize = int.Parse(Console.ReadLine());
                Console.Write("Second array size: ");
                secondArrSize = int.Parse(Console.ReadLine());
            }
        }

        int[] firstArray = new int[firstArrSize];
        int[] secondArray = new int[secondArrSize];

        Console.WriteLine("Elements for first array:");
        for (int i = 0; i < firstArrSize; i++)
        {
            Console.Write("Element [{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Elements for second array:");
        for (int i = 0; i < secondArrSize; i++)
        {
            Console.Write("Element [{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        for (int i = 0; i < firstArrSize; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
                break;
            }
        }
        Console.WriteLine("Two arrays are equal? --> {0}", isEqual);
    }
}