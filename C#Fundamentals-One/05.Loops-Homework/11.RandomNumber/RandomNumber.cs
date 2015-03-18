//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].


using System;
class RandomNumber
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Min: ");
        int minNum = int.Parse(Console.ReadLine());
        Console.Write("Max: ");
        int maxNum = int.Parse(Console.ReadLine());

        Random number = new Random();
        int randomNumber;

        for (int i = 0; i < n; i++)
        {
            randomNumber = number.Next(minNum, maxNum);
            Console.Write(randomNumber + " ");
            
            if (i == n - 1)
            {
                Console.Write(randomNumber);
            }
        }
        Console.WriteLine();
    }
}
