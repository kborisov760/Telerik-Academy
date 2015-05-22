//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of 
//digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
class NumberAsArray
{

    static int[] SumIntegerAsArray(int[] firstNumber, int[] secondNumber)
    {
        int[] sumNumArr = new int[Math.Max(firstNumber.Length, secondNumber.Length) + 1];
        int biggerArr = Math.Max(firstNumber.Length, secondNumber.Length);
        int smallerArr = Math.Min(firstNumber.Length, secondNumber.Length);
        for (int i = 1; i <= Math.Min(firstNumber.Length, secondNumber.Length); i++)
        {
            int tempSum = sumNumArr[sumNumArr.Length - i] + firstNumber[firstNumber.Length - i] + secondNumber[secondNumber.Length - i];
            sumNumArr[sumNumArr.Length - i] = tempSum % 10;
            sumNumArr[sumNumArr.Length - i - 1] = tempSum / 10;
        }

        for (int i = smallerArr + 1; i <= biggerArr; i++)
        {
            if (firstNumber.Length > secondNumber.Length)
            {
                int tempSum = sumNumArr[sumNumArr.Length - i] + firstNumber[firstNumber.Length - i];
                sumNumArr[sumNumArr.Length - i] = tempSum % 10;
                sumNumArr[sumNumArr.Length - i - 1] = tempSum / 10;
            }
            else
            {
                int tempSum = sumNumArr[sumNumArr.Length - i] + firstNumber[secondNumber.Length - i];
                sumNumArr[sumNumArr.Length - i] = tempSum % 10;
                sumNumArr[sumNumArr.Length - i - 1] = tempSum / 10;
            }

        }
        return sumNumArr;
    }

    static void Main()
    {
        Console.Write("Enter first number size:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number size:");
        int secondNumber = int.Parse(Console.ReadLine());
        int[] firstNumArr = new int[firstNumber];
        int[] secondNumArr = new int[secondNumber];

        for (int i = 0; i < firstNumber; i++)
        {
            Console.Write("Element[{0}] for first number = ", i);
            firstNumArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondNumber; i++)
        {
            Console.Write("Element[{0}] for second number = ", i);
            secondNumArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The result is:" + String.Join("", SumIntegerAsArray(firstNumArr, secondNumArr)));

    }
}
