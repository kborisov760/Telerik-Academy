//Problem 11. Adding polynomials

//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;
class AddingPolynomials
{
    static void PrintPolynomial(int[] finalPol)
    {
        Console.WriteLine();
        Console.Write(" f(x)= ");

        for (int i = 0; i < finalPol.Length; i++)
        {
            if (finalPol[i] == 0)
            {
                continue;
            }
            if (i > 0)
            {
                Console.Write(" + ");
            }
            Console.Write(finalPol[i]);

            if (i < finalPol.Length - 1)
            {
                Console.Write("x");
            }
            if (i < finalPol.Length - 2)
            {
                Console.Write("^" + (finalPol.Length - i - 1));
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static int[] PolynomialsSum(int[] polyOne, int[] polyTwo)
    {
        bool firstLonger = polyTwo.Length < polyOne.Length;
        for (int i = 0; i < Math.Min(polyOne.Length, polyTwo.Length); i++)
        {
            if (!firstLonger)
            {
                polyTwo[polyTwo.Length - 1 - i] += polyOne[polyOne.Length - 1 - i];
            }
            else
            {
                polyOne[polyOne.Length - 1 - i] += polyTwo[polyTwo.Length - 1 - i];
            }
        }
        return firstLonger ? polyOne : polyTwo;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter power of first polynomial:");
        int first = int.Parse(Console.ReadLine());
        int[] firstPol = new int[first + 1];

        for (int i = 0; i < firstPol.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            firstPol[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter power of second polynomial:");
        int second = int.Parse(Console.ReadLine());
        int[] secondPol = new int[second + 1];

        for (int i = 0; i < secondPol.Length; i++)
        {
            Console.Write("Element[{0}] = ", i);
            secondPol[i] = int.Parse(Console.ReadLine());
        }

        int[] finalPol = PolynomialsSum(firstPol, secondPol);

        PrintPolynomial(finalPol);
    }
}