namespace MajorantOfArray
{
    using System;
    using System.Linq;
    using Common;

    public class MajorantOfArray
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { '{', '}', ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            Console.WriteLine("Majorants: {0}", string.Join(" ", Sequence.MajorantOfAnArray(numbers)));
        }
    }
}
