//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


using System;
using System.Text;
class DecimalToHexadecimal
{
    private static StringBuilder DecimalToHexadecimalFormat(long decimalNumber)
    {
        StringBuilder hexadecimalNumber = new StringBuilder();
        StringBuilder revertedNumber = new StringBuilder();
        long reminder = 0;
        while (decimalNumber > 0)
        {
            reminder = decimalNumber % 16;
            decimalNumber /= 16;
            switch (reminder)
            {
                case 10: hexadecimalNumber.Append("A");
                    break;
                case 11: hexadecimalNumber.Append("B");
                    break;
                case 12: hexadecimalNumber.Append("C");
                    break;
                case 13: hexadecimalNumber.Append("D");
                    break;
                case 14: hexadecimalNumber.Append("E");
                    break;
                case 15: hexadecimalNumber.Append("F");
                    break;
                default: hexadecimalNumber.Append(reminder.ToString());
                    break;
            }
        }
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            revertedNumber.Append(hexadecimalNumber[hexadecimalNumber.Length - i - 1]);
        }
        return revertedNumber;
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Number in hexadecimal format: {0}", DecimalToHexadecimalFormat(decimalNumber));
    }
}
