//14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBit
{
    private static int ModifyBitAtGivenPosition(int number, int position, int targetBit)
    {
        if (targetBit == 1)
        {
            int maskToOne = 1 << position;
            int numberAndMaskOne = number | maskToOne;
            return numberAndMaskOne;
        }
        else
        {
            int maskToZero = ~(1 << position);
            int numberAndMaskZero = number & maskToZero;
            return numberAndMaskZero;
        }
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter bit to change to: ");
        int targetBit = int.Parse(Console.ReadLine());

        Console.WriteLine("Entered number --> {0} || Output --> {1}", number, ModifyBitAtGivenPosition(number, position, targetBit));
    }
}
