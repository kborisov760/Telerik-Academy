//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is 
//contained in a given text (perform case insensitive search).

using System;
class SubstringInText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Searched subtext: ");
        string subText = Console.ReadLine();
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text.Substring(text[i], 2) == subText)
            {
                counter++;
            }
        }

        Console.WriteLine("\"{0}\" --> {1} time(s).", subText, counter);
    }
}
