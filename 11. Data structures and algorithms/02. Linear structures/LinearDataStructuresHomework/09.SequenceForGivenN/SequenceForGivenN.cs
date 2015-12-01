using Common;
using System;

namespace SequenceForGivenN
{
    public class SequenceForGivenN
    {
        static void Main()
        {
            Console.Write("Enter start number: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter sequence length: ");
            int target = int.Parse(Console.ReadLine());
            
            Sequence.PrintShortestSequence(startNumber, target);
        }
    }
}
