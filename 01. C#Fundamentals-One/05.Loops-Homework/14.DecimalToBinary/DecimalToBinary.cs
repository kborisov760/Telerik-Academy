//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


using System;
class DecimalToBinary
{
    private static string DecimalToBinaryConvertion(long decimalNumber)
    {
        string binaryNumber = string.Empty;
        long reminder = 0;
        
        while (decimalNumber > 0)
        {
            reminder = decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber = reminder.ToString() + binaryNumber;
        }
        
        return binaryNumber;
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Decimal to binary convertion: {0}", DecimalToBinaryConvertion(decimalNumber));
    }
}
