//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

using System;
class MaximalSum
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
        int maxSum = int.MinValue;
        int startPos = 0;
        int endPos = 0;
        for (int i = 0; i < len; i++)
        {
            int curSum = 0;

            for (int j = i; j < len; j++)
            {
                curSum += numbers[j];
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    startPos = i;
                    endPos = j;
                }
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