//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DateDifference
{
    static void Main()
    {
        Console.Write("Enter first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan distance = new TimeSpan();

        distance = secondDate.Date - firstDate.Date;
        Console.WriteLine("Distance: {0} day(s).", distance.TotalDays);
    }
}
