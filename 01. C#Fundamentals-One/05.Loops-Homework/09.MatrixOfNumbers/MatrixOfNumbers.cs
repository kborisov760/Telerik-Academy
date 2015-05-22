//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer 
//number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0}", (row + col));
                    if (col != n - 1)
                    {
                        if (row + col > 9)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }