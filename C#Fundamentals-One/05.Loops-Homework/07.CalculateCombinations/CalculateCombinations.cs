//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n 
//different elements (also known as the number of combinations) is calculated by the following formula: 
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


using System;
class CalculateCombinations
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        double result = 0;
        double factorialForN = 1;
        double factorialForK = 1;
        double factorialForNMunusK = 1;
        double nMinusK = n - k;

        while (n > 1)
        {
            if (k == 1 && nMinusK == 1)
            {
                factorialForN *= n;
                n--;
            }
            
            else
            {
                factorialForN *= n;
                factorialForK *= k;
                factorialForNMunusK *= nMinusK;
                n--;

                if (k > 1)
                {
                    k--;
                }

                if (nMinusK > 1)
                {
                    nMinusK--;
                }
            }
        }

        result = factorialForN / (factorialForK * factorialForNMunusK);

        Console.WriteLine("--------------------");
        Console.WriteLine("The result is {0}", result);
        Console.WriteLine("--------------------");
       
    }
}
