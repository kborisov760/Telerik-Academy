//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sumOfNumber = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of three numbers is {0}.", sumOfNumber);
    }
}