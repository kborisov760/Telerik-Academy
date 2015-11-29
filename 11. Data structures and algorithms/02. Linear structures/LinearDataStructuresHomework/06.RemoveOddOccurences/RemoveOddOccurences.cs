namespace RemoveOddOccurences
{
    using System;
    using System.Linq;
    using Common;

    public class RemoveOddOccurences
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
             
            Console.WriteLine("List before change: {0}", string.Join(" ", numbers));
            Console.WriteLine("List after removing negative numbers: {0}", 
                              string.Join(" ", Sequence.RemoveOddNumberOfTimeOccurence(numbers)));
        }
    }
}
