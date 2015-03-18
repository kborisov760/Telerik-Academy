//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int[] randomedNumber = new int[n];
        
        Random r = new Random();
        int randomNumber = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        int j = 0;
        
        while (true)
        {
            if (randomedNumber[randomedNumber.Length - 1] != 0)
            {
                break;
            }
            
            else
            {
                randomNumber = r.Next(1, n + 1);
                if ((Array.IndexOf(randomedNumber, randomNumber) == -1) && (randomedNumber[j] != numbers[j]))
                {
                    randomedNumber[j] = randomNumber;
                    j++;
                }
            }
        }

        Console.WriteLine(string.Join(" ", randomedNumber));
    }
}