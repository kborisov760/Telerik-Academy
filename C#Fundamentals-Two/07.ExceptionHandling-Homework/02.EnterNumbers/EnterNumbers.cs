//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;
using System.Text;
class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        while (true)
        {
            try
            {
                Console.Write("Input an integer number in the range from {0} to {1}: ", start, end);
                int inpNumber = Int32.Parse(Console.ReadLine());
                if ((inpNumber < start) || (inpNumber > end))
                {
                    Console.WriteLine("Not in range. Please, try again ...");
                    continue;
                }
                return inpNumber;
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
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
    static void Main()
    {
        int[] arr = new int[10];
        int minValue = 2;
        for (int i = 0; i < 10; i++)
        {
            if (i > 0)
            {
                minValue = arr[i - 1] + 1;
            }
            arr[i] = ReadNumber(minValue, 99);
        }
    }
}