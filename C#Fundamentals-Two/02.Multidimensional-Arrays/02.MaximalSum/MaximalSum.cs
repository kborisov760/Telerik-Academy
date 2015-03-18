//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
class MaximalSum
{
    static int[,] SubMatrix(int[,] matrix, int startRow, int startCol, int size) // Subtracting matrix from matrix
    {
        int[,] subMatrix = new int[size, size];
        for (int i = startRow; i < startRow + size; i++)
        {
            for (int j = startCol; j < startCol + size; j++)
            {
                subMatrix[i - startRow, j - startCol] = matrix[i, j];
            }
        }
        return subMatrix;
    }

    static int SumMatrixElements(int[,] Matrix) // Find sum of all matrix elements
    {
        int sum = 0;
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                sum += Matrix[i, j];
            }
        }
        return sum;
    }

    static void PrintMatrix(int[,] matrix) // Printing a matrix  with formating
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter M:");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[m, n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Elemnt[{0},{1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = int.MinValue;
        int bestStartRow = 0;
        int bestStartCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int[,] currentSubMatrix = SubMatrix(matrix, row, col, 3);
                int sum = SumMatrixElements(currentSubMatrix);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestStartRow = row;
                    bestStartCol = col;
                }
            }
        }

        int[,] bestMatrix = SubMatrix(matrix, bestStartRow, bestStartCol, 3);
        PrintMatrix(bestMatrix);
    }
}
