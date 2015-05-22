//Problem 3. Compare char arrays

//Write a program that compares two 
//char arrays lexicographically (letter by letter).

using System;
class CompareCharArray
{
    static void Main()
    {
        Console.Write("Enter first word: ");
        string firstWord = Console.ReadLine();
        Console.Write("Enter second word: ");
        string secondWord = Console.ReadLine();
        string biggerWord = string.Empty;
        bool isEqual = false;

        for (int i = 0; i < Math.Max(firstWord.Length, secondWord.Length); i++)
        {
            if ((int)firstWord[i] > (int)secondWord[i])
            {
                Console.WriteLine("Word with smaller position is {0}.", firstWord);
                break;
            }
            else if ((int)firstWord[i] < (int)secondWord[i])
            {
                Console.WriteLine("Word with smaller position is {0}.", secondWord);
                break;
            }
            else if ((i == Math.Max(firstWord.Length, secondWord.Length) - 1) && ((int)firstWord[i] == (int)secondWord[i]))
            {
                Console.WriteLine("Two words are equal.");
            }
        }
    }
}