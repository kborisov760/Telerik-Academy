//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomizeNumbersTwo
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());

        List<int> randomNumber = new List<int>();
        Random r = new Random();
        int number = 0;

        for (int i = 0; i < n; i++)
        {
            do
            {
                number = r.Next(1, n + 1);
            }

            while (randomNumber.Contains(number));
            randomNumber.Add(number);
        }

        Console.WriteLine(string.Join(" ", randomNumber));
    }
}