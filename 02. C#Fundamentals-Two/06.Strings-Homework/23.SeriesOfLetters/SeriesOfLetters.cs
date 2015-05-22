//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter letters: ");
        string letters = Console.ReadLine();
        char[] lettersArr = new char[letters.Length];
        
        for (int i = 0; i < letters.Length; i++)
			{
			 lettersArr[i] = letters[i];
			}
        
        List<char> output = new List<char>();
        output.Add(lettersArr[0]);

        for (int i = 1; i < lettersArr.Length; i++)
        {
            if (lettersArr[i] == lettersArr[i - 1])
            {
                continue;
            }
            else
            {
                output.Add(lettersArr[i]);
            }
        }

        Console.WriteLine("Output: {0}", String.Join("", output));
    }
}
