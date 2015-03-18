//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.

//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;
using System.Linq;
class ExtractSentences
{
    public static int CountSubstring(string text, string subtr)
    {
        int count = 0;
        text = text.ToLower();
        while (text.IndexOf(subtr) != -1)
        {
            int pos = text.LastIndexOf(subtr);
            if (text.Substring(pos, subtr.Length) != "")
            {
                count++;
                text = text.Remove(pos);
            }
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter some text here:");
        string text = Console.ReadLine();
        Console.Write("Enter key word here:");
        string word = Console.ReadLine();
        string[] sentences = text.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (CountSubstring(sentences[i], word) > 0)
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
    }
}
