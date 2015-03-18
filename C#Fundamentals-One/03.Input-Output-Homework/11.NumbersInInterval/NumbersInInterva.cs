//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and 
//prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;
class NumbersInInterva
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int numberCounter = 0;
        int[] numbersBetweenStartAndEnd = new int[endNumber - startNumber + 1];
        for (int i = startNumber; i < endNumber + 1 ; i++)
        {
            numbersBetweenStartAndEnd[i - startNumber] = i;
            if (numbersBetweenStartAndEnd[i - startNumber] % 5 == 0)
            {
                numberCounter++;
            }
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Start number [{0}] || End number [{1}] --> {2} number(s) between.", startNumber, endNumber, numberCounter);
        Console.WriteLine("--------------------------------------------------------------");
    }
}
