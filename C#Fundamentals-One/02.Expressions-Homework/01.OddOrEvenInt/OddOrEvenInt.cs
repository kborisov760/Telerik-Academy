//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEvenInt
{
    static void Main()
    {
        Console.Write("Enter number to check: ");
        int input = int.Parse(Console.ReadLine());
        
        if (input % 2 == 0)
        {
            Console.WriteLine("The given number is even.");
        }
        else
        {
            Console.WriteLine("The given number is odd.");
        }
    }
}
