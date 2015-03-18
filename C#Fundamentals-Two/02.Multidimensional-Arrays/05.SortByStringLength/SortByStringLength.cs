//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the 
//array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
class SortByStringLength
{
    static void Main()
    {
        Console.Write("Array length: ");
        int len = int.Parse(Console.ReadLine());
        string[] words = new string[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Element[{0}]: ", i);
            words[i] = Console.ReadLine();
        }

        SortArrayByStringLength(words);

        Console.WriteLine(String.Join(", ", words));
    }

    static void SortArrayByStringLength(string[] wordsArray)
    {
        int[] len = new int[wordsArray.Length];

        for (int i = 0; i < len.Length; i++)
        {
            len[i] = wordsArray[i].Length;
        }

        for (int i = 0; i < len.Length; i++)
        {
            int minPos = i; 
            int minLenWord = len[i];
            for (int j = i; j < len.Length; j++)
            {
                if (len[j] < minLenWord)
                {
                    minPos = j;
                    minLenWord = len[j];
                }
            }
            int swap = len[minPos];
            len[minPos] = len[i];
            len[i] = swap;

            string swapWords = wordsArray[minPos];
            wordsArray[minPos] = wordsArray[i];
            wordsArray[i] = swapWords;
        }
    }
}
