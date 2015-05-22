//Problem 11. Binary search

//Write a program that finds the index of given element 
//in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
    class BinarySearch
    {
        static int BinarySearchAlgorithm(int[] array, int value)
        {
            int low = 0, high = array.Length - 1, midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;

                if (value == array[midpoint])
                {
                    return midpoint;
                }

                else if (value < array[midpoint])
                {
                    high = midpoint - 1;
                }
                else
                {
                    low = midpoint + 1;
                }
            }

            return -1;
        }

        static void Main()
        {
            Console.Write("Enter array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int len = numbers.Length;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Elemnt[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter element to search for: ");
            int elementToSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("The index of searched element is " + BinarySearchAlgorithm(numbers, elementToSearch));
        }
    }