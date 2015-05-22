//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SimpleMenuProgram
{
    static int ReverseDigitsOfNumber(int number) // Метод за обръщане на цифрите на едно число
    {
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
        }
        return result;
    }

    static float CalculateAverageOfSequence(int[] numbers) // Метод за пресмятане на средно аритметично на поредица от числа
    {
        float sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        float average = sum / numbers.Length;
        return average;
    }

    static float LinearEquation(float a, float b) // Метод за решаване на квадратно уравнение
    {
        float result = -b / a;
        return result;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose what to do:");
            Console.WriteLine();
            Console.WriteLine("For reversing digits of number press 1");
            Console.WriteLine("For finding average of a sequence press 2");
            Console.WriteLine("For solving linear equation press 3");
            Console.WriteLine("For exit press 4");
            Console.WriteLine();
            Console.Write("Your choice is ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (choice == 1)
            {
                int number;
                while (true)
                {
                    Console.Write("Enter number:");
                    number = int.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("Reversed number is {0}", ReverseDigitsOfNumber(number));
            }
            else if (choice == 2)
            {
                int n;
                while (true)
                {
                    Console.Write("Enter array length:");
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        break;
                    }
                }
                int[] numbers = new int[n];
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Elemnt[{0}] = ", i);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Average of a sequence is {0}", String.Join("", numbers));
            }
            else if (choice == 3)
            {
                int a;
                while (true)
                {
                    Console.Write("Enter a:");
                    a = int.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        break;
                    }
                }
                Console.Write("Enter b:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is {0}", LinearEquation(a, b));
            }
            else if (choice == 4)
            {
                break;
            }
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}