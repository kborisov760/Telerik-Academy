namespace PositiveIntegerNumbers
{
    using System;
    using System.Linq;
    using Common;

    public class PositiveIntegerNumbers
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            Console.WriteLine("Sum =  {0}", Calculate.CalculateSum(numbers));
            Console.WriteLine("Average = {0}", Calculate.CalculateAverage(numbers));
        }
    }
}