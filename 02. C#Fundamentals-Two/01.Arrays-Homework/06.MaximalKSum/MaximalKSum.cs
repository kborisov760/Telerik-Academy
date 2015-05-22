//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());    
        }
        
        Array.Sort(numbers);

        Console.Write("Enter number of elements for sum: ");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        int counter = 1;

        while (k > 0)
        {
                sum += numbers[numbers.Length - counter];
                counter++;
                k--;
        }

        Console.WriteLine("The sum is: {0}", sum);
    }
}