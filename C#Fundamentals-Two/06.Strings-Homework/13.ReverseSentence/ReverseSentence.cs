//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter string:");
        string input = Console.ReadLine();
        char[] revInput = new char[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            revInput[i] = input[i];
        }
        Array.Reverse(revInput);
        Console.WriteLine("{0}", string.Join("", revInput));
    }
}
