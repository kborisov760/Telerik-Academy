namespace LongestSubsequence
{
    using System;
    using System.Linq;
    using Common;

    public class LongestSubsequence
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            Console.WriteLine("Longest sequence: {0}", string.Join(" ", Sequence.LongestSubsequence(numbers)));
        }
    }
}
