//Problem 8. Binary short

//Write a program that shows the binary representation 
//of given 16-bit signed integer number (the C# type short).

using System;
class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter number to convert:");
        int signedNum = int.Parse(Console.ReadLine());
        string str = "";
        int newNum = signedNum + 32768;
        if (newNum == 0)
        {
            str = "0";
        }
        while (newNum > 0)
        {

            str = newNum % 2 + str;
            newNum /= 2;
        }
        string newStr = str.PadLeft(15, '0');
        newStr = '1' + newStr;
        Console.WriteLine("The new number is {0}", newStr);
    }
}
