//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;
class ExtractBit
{
    private static string CheckBitAtPosition(uint number)
    {
        uint mask = 1 << 3;
        uint numberAndMask = number & mask;
        uint bit = numberAndMask >> 3;

        string outstring = (bit == 0) ? "0" : "1";
        return outstring;

    }
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------");
        Console.WriteLine("Bit at position \"3\" --> {0}", CheckBitAtPosition(number));
        Console.WriteLine("-------------------------");
    }
}
