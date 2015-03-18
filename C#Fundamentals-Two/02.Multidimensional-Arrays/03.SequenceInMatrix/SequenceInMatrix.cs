//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
class SequenceInMatrix
{
    static string[] LongestSequence(string[] elements)
    {

        string maxElem = elements[0];
        int maxCount = 1;
        int counter = 1;

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] == elements[i - 1])
            {
                counter++;

                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxElem = elements[i];
                }
            }
            else
            {
                counter = 1;
            }
        }

        string[] vector = new string[maxCount];
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = maxElem;
        }
        return vector;
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());

        string[,] wordMatrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Element[{0},{1}]: ", row, col);
                wordMatrix[row, col] = Console.ReadLine();
            }
        }

        int bestResCount = 0;
        string bestSequence = "";

        for (int i = 0; i < wordMatrix.GetLength(0); i++)
        {
            string[] rowVector = new string[wordMatrix.GetLength(1)];
            for (int j = 0; j < wordMatrix.GetLength(1); j++)
            {
                rowVector[j] = wordMatrix[i, j];
            }
            if (LongestSequence(rowVector).Length > bestResCount)
            {
                bestResCount = LongestSequence(rowVector).Length;
                bestSequence = String.Join(",", LongestSequence(rowVector));
            }
        }

        for (int i = 0; i < wordMatrix.GetLength(1); i++)
        {
            string[] colVector = new string[wordMatrix.GetLength(0)];
            for (int j = 0; j < wordMatrix.GetLength(0); j++)
            {
                colVector[j] = wordMatrix[j, i];
            }
            if (LongestSequence(colVector).Length > bestResCount)
            {
                bestResCount = LongestSequence(colVector).Length;
                bestSequence = String.Join(",", LongestSequence(colVector));
            }
        }

        int maxRow = wordMatrix.GetLength(0);
        int maxCol = wordMatrix.GetLength(1);
        int startCol = 0;
        int startRow = 0;
        for (startRow = 0; startRow < maxRow; startRow++)
        {
            string[] vector = new string[Math.Min(maxRow - startRow, maxCol - startCol)];
            for (int j = 0; j < vector.Length; j++)
            {
                vector[j] = wordMatrix[startRow + j, startCol + j];
            }
            if (LongestSequence(vector).Length > bestResCount)
            {
                bestResCount = LongestSequence(vector).Length;
                bestSequence = String.Join(",", LongestSequence(vector));
            }
        }

        startRow = 0;
        for (startCol = 1; startCol < maxCol; startCol++)
        {
            string[] vector = new string[Math.Min(maxRow - startRow, maxCol - startCol)];
            for (int j = 0; j < vector.Length; j++)
            {
                vector[j] = wordMatrix[startRow + j, startCol + j];
            }
            if (LongestSequence(vector).Length > bestResCount)
            {
                bestResCount = LongestSequence(vector).Length;
                bestSequence = String.Join(",", LongestSequence(vector));
            }
        }

        maxRow = wordMatrix.GetLength(0);
        maxCol = wordMatrix.GetLength(1);
        startCol = maxCol - 1;
        startRow = 0;
        for (startRow = 0; startRow < maxRow; startRow++)
        {
            string[] vector = new string[Math.Min(maxRow - startRow, startCol + 1)];
            for (int j = 0; j < vector.Length; j++)
            {
                vector[j] = wordMatrix[startRow + j, startCol - j];
            }
            if (LongestSequence(vector).Length > bestResCount)
            {
                bestResCount = LongestSequence(vector).Length;
                bestSequence = String.Join(",", LongestSequence(vector));
            }
        }

        startRow = 0;
        for (startCol = maxCol - 1; startCol >= 0; startCol--)
        {
            string[] vector = new string[Math.Min(maxRow - startRow, startCol + 1)];
            for (int j = 0; j < vector.Length; j++)
            {
                vector[j] = wordMatrix[startRow + j, startCol - j];
            }
            if (LongestSequence(vector).Length > bestResCount)
            {
                bestResCount = LongestSequence(vector).Length;
                bestSequence = String.Join(",", LongestSequence(vector));
            }
        }
        Console.WriteLine(bestSequence);
    }
}
