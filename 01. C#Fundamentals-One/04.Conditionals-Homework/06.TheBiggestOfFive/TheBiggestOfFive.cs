//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
class TheBiggestOfFive
{
    private static double ReturnTheBiggestOfFiveNumbers(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber, double fifthNumber)
    {
        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            return firstNumber;
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            return secondNumber;
        }
        else if (thirdNumber > fifthNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            return thirdNumber;
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            return fourthNumber;
        }
        else
        {
            return fifthNumber;
        }
    }
    static void Main()
    {
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The biggest of five numbers is {0}.", 
                            ReturnTheBiggestOfFiveNumbers(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber));
    }
}
