//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//! За да работи четвъртия вариант трябва да се закоментира всичкия код, защото се бъркат някъде променливите и не прекъсва While цикъла

using System;
using System.Collections.Generic;
class FillMatrix
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] >= 1 && matrix[row, col] <= 9)
                {
                    Console.Write(matrix[row, col] + "   ");
                }
                else
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                
            }
            Console.WriteLine();
        }
    }

    static void ChangeDirection(ref string currentDirection)
    {
        if (currentDirection == "Down")
        {
            currentDirection = "Right";
        }
        else if (currentDirection == "Right")
        {
            currentDirection = "Up";
        }
        else if (currentDirection == "Up")
        {
            currentDirection = "Left";
        }
        else
        {
            currentDirection = "Down";
        }
    }

    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int[,] matrix = new int[n, n];

        //Variant A:

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = row + counter + 1;
                counter += n;
            }
            counter = 0;
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Variant A:");
        Console.WriteLine("---------------"); 
        PrintMatrix(matrix);

        Console.WriteLine();

        //Variant B:

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    counter++;
                    matrix[row, col] = counter;
                }
            }
            else
            {
                for (int rows = n - 1; rows >= 0; rows--)
                {
                    counter++;
                    matrix[rows, col] = counter;
                }
            }
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Variant B:");
        Console.WriteLine("---------------");
        PrintMatrix(matrix);

        //Variant C:

        int cols = 1;
        int count = 0;

        for (int rows = n - 1; rows >= 0; rows--)
        {
            int curRow = rows;
            int curCol = 0;

            for (cols = curRow; cols < n; cols++)
            {
                count++;
                matrix[curRow, curCol] = count;
                curRow++;
                curCol++;
            }
        }

        for (cols = 1; cols < n; cols++)
        {
            int curRow = 0;
            int curCol = cols;

            for (int i = cols; i < n; i++)
            {
                count++;
                matrix[curRow, curCol] = count;
                curRow++;
                curCol++;
            }
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Variant C:");
        Console.WriteLine("---------------");
        PrintMatrix(matrix);

        //Variant D:

        int currRow = 0;
        int currCol = 0;
        int counterR = 1;
        string direction = "Down";
        matrix[0, 0] = 1;
        int newRow = 0;
        int newCol = 0;
        while (true)
        {
            //ако counter-а е достигнал стойност n^2 излизаме от цикъла 

            if (counterR == n * n)
            {
                break;
            }
            //пресмятане на новите кординати при текущата посока
            if (direction == "Down")
            {
                newRow = currRow + 1;
                newCol = currCol;
            }
            else if (direction == "Right")
            {
                newRow = currRow;
                newCol = currCol + 1;
            }
            else if (direction == "Up")
            {
                newRow = currRow - 1;
                newCol = currCol;
            }
            else if (direction == "Left")
            {
                newRow = currRow;
                newCol = currCol - 1;
            }
            //проверяваме дали има такава клетка

            if (newRow >= n || newCol >= n || newRow < 0 || newCol < 0) // ако няма такава клетка сменяме посоката
            {
                ChangeDirection(ref direction);
                continue; // и се връщаме в началото на цикъла
            }
            else if (matrix[newRow, newCol] != 0)
            {
                ChangeDirection(ref direction);
                continue;
            }

            //1. Ако съществува и е свободна:
            //1.1 Попълваме я
            //1.2 Увеличаваме брояча
            //1.3 Заменяме кординатите до момента с новите кординати

            counterR++;
            matrix[newRow, newCol] = counterR;
            currCol = newCol;
            currRow = newRow;
        }
        Console.WriteLine("---------------");
        Console.WriteLine("Variant D:");
        Console.WriteLine("---------------");
        PrintMatrix(matrix);
    }
}
