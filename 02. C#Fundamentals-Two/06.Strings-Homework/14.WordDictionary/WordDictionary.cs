//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class WordDictionary
{
    static void Main()
    {
        string[] words = {"NET", "CLR", "namespace" };
        string[] explanations = { "platform for applications from Microsoft", "managed execution environment for .NET", "hierarchical organization of classes"};
        Console.Write("Word: ");
        string inputWord = Console.ReadLine();
        for (int i = 0; i < words.Length; i++)
        {
            if (inputWord == words[i])
            {
                Console.WriteLine("Explanation: " + explanations[i]);
                break;
            }
        }
    }
}