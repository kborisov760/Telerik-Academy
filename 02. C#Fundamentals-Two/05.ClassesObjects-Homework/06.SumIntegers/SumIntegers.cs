using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static int SumIntegersMethod(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("--------------------");
            Console.WriteLine("The sum is {0}", SumIntegersMethod(numbers));
        }
    }
}
