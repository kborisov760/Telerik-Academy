//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

using System;
class MaxSequence
{
    static void Main()
    {
        Console.Write("How much numbers do you want?: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxNumber = numbers[0];
        int counter = 1;
        int maxCount = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i-1])
            {
                counter++;

                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxNumber = numbers[i];
                }
            }
            else
            {
                counter = 1;
            }
        }

        string console = "{";
        for (int i = 0; i < maxCount; i++)
        {
            console = console + maxNumber;
            if (i < maxCount - 1)
            {
                console = console + ",";
            }
        }
        Console.WriteLine("The result is: " + console + "}");
    }
}
