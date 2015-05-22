//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;
using System.Text;
class SquareRoot
{
    static void Main()
    {
        while (true)
        {
            bool noError = false;
            try
            {
                Console.Write("Input a valid positive number:");
                int inpNumber = Int32.Parse(Console.ReadLine());
                if (inpNumber < 0)
                {
                    Console.WriteLine("Negative number. Please, try again ...");
                    continue;
                }
                double result = Math.Sqrt(inpNumber);
                Console.WriteLine("The result is: {0}", result);
                noError = true;
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                if (noError)
                    Console.WriteLine("Good Bye");
            }
        }
    }
}
