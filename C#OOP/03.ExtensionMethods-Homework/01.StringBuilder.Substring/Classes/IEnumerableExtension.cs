namespace ExtensionMethods.Classes
{
    using System;
    using System.Collections.Generic;
    public static class IEnumerableExtension
    {
        public static double SumElements<T>(this IEnumerable<T> elements) where T : struct
        {
            double result = 0;
            foreach (var item in elements)
            {
                result += (double)Convert.ChangeType(item, typeof(double));
            }
            return result;
        }

        public static double ProductElements<T>(this IEnumerable<T> elements) where T : struct
        {
            double result = 1;
            foreach (var item in elements)
            {
                result *= (double)Convert.ChangeType(item, typeof(double));
            }
            return result;
        }

        public static double MinElement<T>(this IEnumerable<T> elements) where T : struct
        {
            double result = Double.MaxValue;
            foreach (var item in elements)
            {
                result = Math.Min(result, (double)Convert.ChangeType(item, typeof(double)));
            }
            return result;
        }

        public static double MaxElement<T>(this IEnumerable<T> elements) where T : struct
        {
            double result = Double.MinValue;
            foreach (var item in elements)
            {
                result = Math.Max(result, (double)Convert.ChangeType(item, typeof(double)));
            }
            return result;
        }

        public static double AverageElements<T>(this IEnumerable<T> elements) where T : struct
        {
            double sumElements = 0;
            int counterElements = 0;
            foreach (var item in elements)
            {
                sumElements += (double)Convert.ChangeType(item, typeof(double));
                counterElements++;
            }
            return sumElements / counterElements;
        }
    }
}
