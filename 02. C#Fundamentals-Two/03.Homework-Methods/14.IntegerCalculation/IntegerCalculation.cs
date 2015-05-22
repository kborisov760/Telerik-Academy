//Problem 14. Integer calculations

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
class IntegerCalculation
{
    static float MinMaxAvgSumProductOfSequence(int[] numbers, int choice)
    {
        while (true)
        {
            if (choice == 1)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            else if (choice == 2)
            {
                Array.Sort(numbers);
                return numbers[0];
            }

            else if (choice == 3)
            {
                Array.Sort(numbers);
                return numbers[numbers.Length - 1];
            }

            else if (choice == 4)
            {
                int product = 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
                return product;
            }

            else
            {
                float sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                float average = sum / numbers.Length;
                return average;
            }
        }
        return -1;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose what to do:");
            Console.WriteLine();
            Console.WriteLine("For finding sum of a sequence press 1");
            Console.WriteLine("For finding min value of a sequence press 2");
            Console.WriteLine("For finding max value of a sequence press 3");
            Console.WriteLine("For finding the product of a sequence press 4");
            Console.WriteLine("For finding average number in a sequence press 5");
            Console.WriteLine("For exit press 6");
            Console.WriteLine();
            Console.Write("Your choice is ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
            {
                Console.Write("Enter sequence length:");
                int n = int.Parse(Console.ReadLine());
                int[] numbers = new int[n];
                int len = numbers.Length;

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("number {0} = ", i + 1);
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The result is {0}", String.Join("", MinMaxAvgSumProductOfSequence(numbers, choice)));
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
            else if (choice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong input! Try again..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
