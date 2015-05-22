//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
using System.Text;
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter number here: ");
        int number = int.Parse(Console.ReadLine());
        string numToStr = number.ToString();
        string revertedStr = string.Empty;
        int sum = 0;
        
        for (int i = 0; i < numToStr.Length; i++)
        {
            sum += int.Parse(numToStr[i].ToString());
        }

        Console.WriteLine("The sum is {0}.", sum);

        for (int i = 0; i < numToStr.Length; i++)
        {
           revertedStr += String.Join("", numToStr[numToStr.Length - 1 - i]);
        }

        Console.WriteLine("Reverted number is {0}.", revertedStr);

        string croppedStr = numToStr.Substring(0, 3);
        string concatedStr = String.Concat(numToStr[revertedStr.Length - 1], croppedStr);

        Console.WriteLine("Number after moving last number on first position is {0}.", concatedStr);

        StringBuilder finalStringNumber = new StringBuilder();

        finalStringNumber.Append(numToStr[0]);
        finalStringNumber.Append(numToStr[2]);
        finalStringNumber.Append(numToStr[1]);
        finalStringNumber.Append(numToStr[3]);

        Console.WriteLine("Number after exchanging second and third digit is {0}.", finalStringNumber);
    }
}
