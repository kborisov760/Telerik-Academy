//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        Console.WriteLine("Output: " + ChangeUnicodeCharacters(input));
    }

    static StringBuilder ChangeUnicodeCharacters(string input)
    {
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            output.Append(String.Format("\\u" + ((int) input[i]).ToString( "x4" )));
        }

        return output;
    }
}
