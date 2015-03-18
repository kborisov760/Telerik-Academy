//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
class ReverseNumber
{
    static int ReverseNumberMethod(int input)
    {
        int reversedNumber = 0;
        var inpStr = input.ToString();
        var inpStrReversed = new List<char>();
        for (int i = 0; i < inpStr.Length; i++)
        {
            inpStrReversed.Add(inpStr[inpStr.Length - 1 - i]);
        }
        reversedNumber = int.Parse(String.Join("", inpStrReversed));
        return reversedNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number: {0}", ReverseNumberMethod(number));
    }
}