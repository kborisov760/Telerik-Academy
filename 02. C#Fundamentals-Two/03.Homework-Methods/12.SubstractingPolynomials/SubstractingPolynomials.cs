//Problem 12. Subtracting polynomials

//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
class SubstractingPolynomials
{
    class PolynomialSubMul
    {
        static void PrintPolynomial(int[] finalPol)
        {
            Console.WriteLine();
            Console.Write("The result is f(x)= ");

            for (int i = 0; i < finalPol.Length; i++)
            {
                if (finalPol[i] == 0)
                {
                    continue;
                }
                
                if (i > 0)
                {
                    if (finalPol[i] < 0)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(" + ");
                    }
                }

                if (Math.Abs(finalPol[i]) != 1 || (finalPol.Length - 1) == i)
                {
                    Console.Write(Math.Abs(finalPol[i]));    
                }
                
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
        
        static int[] PolynomialsSumSub(int[] polyOne, int[] polyTwo, bool ToSum)
        {
            bool firstLonger = polyTwo.Length < polyOne.Length;

            if (!ToSum)
            {
                for (int i = 0; i < polyTwo.Length; i++)
                {
                    polyTwo[i] *= (-1);
                }                
            }

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

        static int[] PolynomialMul(int[] polyOne, int[] polyTwo)
        {
            int[] finalPol = new int[polyOne.Length + polyTwo.Length - 1];
            for (int i = 0; i < polyOne.Length; i++)
            {
                for (int j = 0; j < polyTwo.Length; j++)
                {
                    finalPol[i+j] += polyOne[i] * polyTwo[j];
                }
            }
            return finalPol;
        }
        
        
        static void Main()
        {
            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("For add press 1");
            Console.WriteLine("For subtraction press 2");
            Console.WriteLine("For multiplication press 3");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter power of first polynomial:");
            int first = int.Parse(Console.ReadLine());
            int[] firstPol = new int[first + 1];

            for (int i = 0; i < firstPol.Length; i++)
            {
                Console.Write("Elemnt[{0}] = ", i);
                firstPol[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter power of second polynomial:");
            int second = int.Parse(Console.ReadLine());
            int[] secondPol = new int[second + 1];

            for (int i = 0; i < secondPol.Length; i++)
            {
                Console.Write("Elemnt[{0}] = ", i);
                secondPol[i] = int.Parse(Console.ReadLine());
            }
            if (choice == 1)
            {
                int[] finalPol = PolynomialsSumSub(firstPol, secondPol, true);
                PrintPolynomial(finalPol);
            }
            else if (choice == 2)
            {
                int[] finalPol = PolynomialsSumSub(firstPol, secondPol, false);
                PrintPolynomial(finalPol);
            }
            else if (choice == 3)
            {
                int[] finalPol = PolynomialMul(firstPol, secondPol);
                PrintPolynomial(finalPol);
            }
        }
    }
}

    }
}
