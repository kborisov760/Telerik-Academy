//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Linq;
class ReverseString
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        var reversed = input.Reverse();
        Console.WriteLine("Reversed --> {0}", string.Join("", reversed));
    }
}
