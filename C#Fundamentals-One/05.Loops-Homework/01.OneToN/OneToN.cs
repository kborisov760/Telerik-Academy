//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive 
//integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;
using System.Text;
class OneToN
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        StringBuilder outstring = new StringBuilder();
        
        for (int i = 1; i <= n; i++)
        {
            if (i == n)
            {
                outstring.Append(i);
                break;
            }
            
            outstring.Append(i);
            outstring.Append(" ");

        }
        
        Console.WriteLine(outstring);
    }
}
