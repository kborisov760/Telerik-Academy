//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Enter your word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        char[] wordToChar = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            wordToChar[i] = word[i];
        }

        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(65 + i);
        }

        int[] indexes = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            indexes[i] = Array.IndexOf(alphabet, wordToChar[i]);
        }
        Console.WriteLine("--------------------------------");
        for (int i = 0; i < indexes.Length; i++)
        {
            Console.WriteLine("Letter {0} --> Index[{1}]", wordToChar[i], indexes[i]);
        }
        Console.WriteLine("--------------------------------");
    }
}
