//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBitFromInteger
{
    private static string ExtractBitFromPosition(int number, int position)
    {
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        string outstring = (bit == 0) ? "0" : "1";
        return outstring;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------");
        Console.WriteLine("Bit at position \"{0}\" --> {1}",position, ExtractBitFromPosition(number, position));
        Console.WriteLine("-------------------------");
    }
}
