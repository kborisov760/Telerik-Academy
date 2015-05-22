//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class ForbiddenWords
{
    static string ReplaceForbiddenWords(string text)
    {
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            if (text.IndexOf(forbiddenWords[i]) != -1)
            {
                text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
        }
        return text;
    }

    static void Main()
    {
        Console.Write("Enter text here: ");
        string text = Console.ReadLine();
        Console.WriteLine("Text with replaced words: " + ReplaceForbiddenWords(text));
    }
}