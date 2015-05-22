//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double firstSorted = 0, secondSorted = 0, thirdSorted = 0;

        if (firstNumber > secondNumber && firstNumber > thirdNumber) // Case 1: Firts number is biggest
        {
            firstSorted =  firstNumber;
            
            if (secondNumber > thirdNumber)
            {
                secondSorted = secondNumber;
                thirdSorted = thirdNumber;
            }
            else
            {
                secondSorted = thirdNumber;
                thirdSorted = secondNumber;
            }
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber) // Case 2: Second number is biggest
        {
            firstSorted = secondNumber;

            if (firstNumber > thirdNumber)
            {
                secondSorted = firstNumber;
                thirdSorted = thirdNumber;
            }
            else
            {
                secondSorted = thirdNumber;
                thirdSorted = firstNumber;
            }
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber) // Case 3: Third number is biggest
        {
            firstSorted = thirdNumber;

            if (firstNumber > secondNumber)
            {
                secondSorted = firstNumber;
                thirdSorted = secondNumber;
            }
            else
            {
                secondSorted = secondNumber;
                thirdSorted = firstNumber;
            }
        }

        if ((firstNumber == secondNumber) && (firstNumber == thirdNumber) && (secondNumber == thirdNumber)) // Case 4: Three numbers are equal
        {
            firstSorted = firstNumber;
            secondSorted = secondNumber;
            thirdSorted = thirdNumber;
        }

        Console.WriteLine("Before sorting: First number: {0} | Second number: {1} | Third number: {2}", firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("---------------------");
        Console.WriteLine("After sorting:  First number: {0} | Second number: {1} | Third number: {2}", firstSorted, secondSorted, thirdSorted);
    }
}
