//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;
class PrimeNumberCheck
{
    private static bool IsPrimeNumber(int number)
    {
        if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            return true;
        }
        if (number == 1)
        {
            return false;
        }
        if (number % 2  == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static void Main()
    {
        Console.Write("Enter number to check: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Is prime number? {0}", IsPrimeNumber(number));
    }
}
