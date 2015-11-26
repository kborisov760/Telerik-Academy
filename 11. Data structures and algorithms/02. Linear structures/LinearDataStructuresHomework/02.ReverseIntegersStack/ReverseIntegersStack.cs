namespace ReverseIntegersStack
{
    using System;
    using System.Linq;

    class ReverseIntegersStack
    {
        static void Main()
        {
            Console.Write("Enter number separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        }
    }
}