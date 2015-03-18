//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;
class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array of numbers length: ");
        int len = int.Parse(Console.ReadLine());

        int[] numbers = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write("Element[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxFrequentElement = numbers[0];
        int currentCounter = 1;
        int maxFrequentCounter = 1;

        Array.Sort(numbers);

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                currentCounter++;

                if (currentCounter > maxFrequentCounter)
                {
                    maxFrequentCounter = currentCounter;
                    maxFrequentElement = numbers[i];
                }
            }
            else
            {
                currentCounter = 1;
            }
        }

        Console.WriteLine("Max frequent element --> {0} | Repeated {1} times.", maxFrequentElement, maxFrequentCounter);
    }
}