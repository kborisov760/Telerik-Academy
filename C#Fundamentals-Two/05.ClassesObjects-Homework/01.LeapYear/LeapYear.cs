//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int enteredYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} leap year? --> {1}", enteredYear, DateTime.IsLeapYear(enteredYear));
    }
}