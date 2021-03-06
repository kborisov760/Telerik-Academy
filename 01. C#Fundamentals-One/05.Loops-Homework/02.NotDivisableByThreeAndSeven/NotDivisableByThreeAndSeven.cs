﻿//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n 
//and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

using System;
using System.Text;
class NotDivisableByThreeAndSeven
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        StringBuilder outstring = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                if (i == n)
                {
                    outstring.Append(i);
                    break;
                }

                outstring.Append(i);
                outstring.Append(" ");
            }
        }

        Console.WriteLine(outstring);
    }
}
