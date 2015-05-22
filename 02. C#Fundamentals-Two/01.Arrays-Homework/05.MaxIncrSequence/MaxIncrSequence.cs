//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Text;

class MaximalIncreasingSequence
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

        int currentStartPosition = 0;
        int maxStartPosition = currentStartPosition;
        int counter = 1;
        int maxCounter = 1;

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > numbers[i-1])
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxStartPosition = currentStartPosition;
                }
            }

            else
            {
                counter++;
                currentStartPosition = i;
            }
        }

        string consoleOutput = "{";
        for (int i = 0; i < maxCounter; i++)
        {
            consoleOutput = consoleOutput + numbers[maxStartPosition + i];
            if (i < maxCounter - 1)
            {
                consoleOutput = consoleOutput + ",";
            }
        }

        Console.WriteLine("The result is: " + consoleOutput + "}");
    }
}

