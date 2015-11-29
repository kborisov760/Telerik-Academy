namespace ForeachOccurences
{
    using System;
    using System.Linq;
    using Common;

    public class ForeachOccurences
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] {'{', '}' , ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            var countedValuesDictionary = Sequence.CountEachElementOccurence(numbers);

            foreach (var item in countedValuesDictionary)
            {
                Console.WriteLine("{0} --> {1} time(s)", item.Key, item.Value);
            }
        }
    }
}
