//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: 

using System;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        double factorialN = 1;
        double nByTwo = 2 * n;
        double nPlusOne = n + 1;
        double factorialNMulTwo = 1;
        double factorialNPlusOne = 1;

        while (n > 1)
        {
            factorialN *= n;
            n--;
        }

        while (nByTwo > 1)
        {
            factorialNMulTwo *= nByTwo;
            nByTwo--;
        }

        while (nPlusOne > 1)
        {
            factorialNPlusOne *= nPlusOne;
            nPlusOne--;
        }

        double result = factorialNMulTwo / (factorialNPlusOne * factorialN);

        Console.WriteLine("The {0}th Catalan number is {1}", n, result);
    }
}