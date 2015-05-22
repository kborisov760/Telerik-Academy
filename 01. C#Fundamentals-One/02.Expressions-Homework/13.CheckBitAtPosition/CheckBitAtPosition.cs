//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;
class CheckBitAtPosition
{
    private static bool CheckBitAtGivenPosition(int number, int position)
    {
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;

        bool output = (bit == 1) ? true : false;
        return output;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------");
        Console.WriteLine("Bit at position \"{0}\" has a valie \"1\"? --> {1}", position, CheckBitAtGivenPosition(number, position));
        Console.WriteLine("-------------------------");
    }
}
