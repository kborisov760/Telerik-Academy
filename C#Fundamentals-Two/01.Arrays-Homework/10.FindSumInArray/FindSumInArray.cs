//Problem 10. Find sum in array

//Write a program that finds in given array 
//of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        bool tmp = false;
        int len = numbers.Length;
        int startPos = 0;
        int endPos = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Elemnt[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter sum: ");
        int enteredSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < len; i++)
        {
            int curSum = 0;

            for (int j = i; j < len; j++)
            {
                curSum += numbers[j];
                if (curSum == enteredSum)
                {
                    startPos = i;
                    endPos = j;
                    tmp = true;
                    break;
                }
            }

            if (tmp)
            {
                break;
            }
        }

        int[] sumNumbers = new int[endPos - startPos + 1];

        for (int i = 0; i < endPos - startPos + 1; i++)
        {
            sumNumbers[i] = numbers[startPos + i];
        }

        Console.WriteLine(string.Join(", ", sumNumbers));
    }
}
