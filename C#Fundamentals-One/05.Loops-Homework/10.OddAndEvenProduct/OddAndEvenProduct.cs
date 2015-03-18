//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.


using System;
using System.Text;
using System.Linq;
class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by a space: ");
        double[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t', ',' },
                           StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
        double oddPositionProduct = 1;
        double evenPositionProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if ((i+1) % 2 == 0)
            {
                evenPositionProduct *= numbers[i];
            }
            else
            {
                oddPositionProduct *= numbers[i];
            }
        }

        string output = evenPositionProduct == oddPositionProduct ? "Yes" : "No";
        Console.WriteLine(output);
    }
}