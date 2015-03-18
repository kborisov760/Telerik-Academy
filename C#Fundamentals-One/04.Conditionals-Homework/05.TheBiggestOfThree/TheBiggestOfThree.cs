//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Text;
using System.Linq;
class TheBiggestOfThree
{
    private static double ReturnBiggestOfThree(double firstNumber, double secondNumber, double thirdNumber)
    {
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            return firstNumber;
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            return secondNumber;
        }
        else
        {
            return thirdNumber;
        }
    }

    static void Main()
    {
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The biggest from three numbers is {0}", ReturnBiggestOfThree(a, b, c));
        
    }
}
