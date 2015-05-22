//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
class EnglishDigit
{
    static string GetLastDigit(int number)
    {
        string numToStr = number.ToString();
        char lastDigit = numToStr[numToStr.Length - 1];
        switch (lastDigit)
        {
            case '1': return "one";
                break;
            case '2': return "two";
                break;
            case '3': return "three";
                break;
            case '4': return "four";
                break;
            case '5': return "five";
                break;
            case '6': return "six";
                break;
            case '7': return "seven";
                break;
            case '8': return "eight";
                break;
            case '9': return "nine";
                break;
            default: return "zero";
                break;
        }
       
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(number));
    }
}
