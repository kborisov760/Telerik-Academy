namespace ReverseIntegersStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseIntegersStack
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            var stackNumber = new Stack<int>();
            var reversedNumbers = new List<int>();

            foreach (var number in numbers)
            {
                stackNumber.Push(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = stackNumber.Pop();
                reversedNumbers.Add(currentNumber);
            }

            Console.WriteLine("Original collection: {0}", string.Join(" ", numbers));
            Console.WriteLine("Reversed collection: {0}", string.Join(" ", reversedNumbers));
        }
    }
}