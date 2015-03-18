//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
class NumberComparer
{
    static void Main()
    {
        Console.Write("A = ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger number is {0}", Math.Max(firstNumber, secondNumber));
    }
}