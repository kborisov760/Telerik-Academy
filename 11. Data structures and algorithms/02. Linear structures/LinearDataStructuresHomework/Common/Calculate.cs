namespace Common
{
    using System.Collections.Generic;

    public class Calculate
    {
        public static long CalculateSum(List<int> numbers)
        {
            long sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static decimal CalculateAverage(List<int> numbers)
        {
            decimal average = 0;
            long sum = CalculateSum(numbers);

            average = sum / numbers.Count;

            return average;
        }
    }
}
