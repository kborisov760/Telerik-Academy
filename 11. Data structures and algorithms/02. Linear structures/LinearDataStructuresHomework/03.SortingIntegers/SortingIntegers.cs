namespace SortingIntegers
{
    using System;
    using System.Linq;

    public class SortingIntegers
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            numbers.Sort();

            Console.WriteLine("Sorted numbers: {0}", string.Join(" ", numbers));
        }
    }
}
