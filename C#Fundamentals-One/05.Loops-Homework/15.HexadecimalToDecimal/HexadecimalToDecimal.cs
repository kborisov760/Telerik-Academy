//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.


using System;
using System.Numerics;
class HexadecimalToDecimal
{
    static private long HexadecimalToDecimalConvertion(string hexadecimalNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            int len = hexadecimalNumber.Length;
            
            switch (hexadecimalNumber[i])
            {
                case 'A': decimalNumber += 10 * (long)Math.Pow(16, (len - i - 1));
                    break;
                case 'B': decimalNumber += 11 * (long)Math.Pow(16, (len - i - 1));
                    break;
                case 'C': decimalNumber += 12 * (long)Math.Pow(16, (len - i - 1));
                    break;
                case 'D': decimalNumber += 13 * (long)Math.Pow(16, (len - i - 1));
                    break;
                case 'E': decimalNumber += 14 * (long)Math.Pow(16, (len - i - 1));
                    break;
                case 'F': decimalNumber += 15 * (long)Math.Pow(16, (len - i - 1));
                    break;
                default: decimalNumber += int.Parse(hexadecimalNumber[i].ToString()) * (long)Math.Pow(16, (len - i - 1));
                    break;
            }
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexaNumber = Console.ReadLine();
        Console.WriteLine("Number in decimal format is {0}", HexadecimalToDecimalConvertion(hexaNumber));
    }
}