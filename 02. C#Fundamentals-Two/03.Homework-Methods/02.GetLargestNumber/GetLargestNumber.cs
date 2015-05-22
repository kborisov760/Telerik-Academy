//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber, secondNumber);
    }
    static void Main()
    {
        Console.Write("A: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("C: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggestNumber = 0;

        if (GetMax(firstNumber, secondNumber) == firstNumber && GetMax(firstNumber, thirdNumber) == firstNumber)
        {
            biggestNumber = firstNumber;
        }
        else if (GetMax(firstNumber, secondNumber) == secondNumber && GetMax(secondNumber, thirdNumber) == secondNumber)
        {
            biggestNumber = secondNumber;
        }
        else
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}