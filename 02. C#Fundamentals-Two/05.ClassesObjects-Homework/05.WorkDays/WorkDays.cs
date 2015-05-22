//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
class WorkDaysProgram
{
    static int WorkDays(DateTime inputDay)
    {
        int countWorkDays = 0;
        DateTime currentDay = new DateTime();
        currentDay = DateTime.Parse(DateTime.Now.ToString().Substring(0, 10));
        DateTime[] offDays = new DateTime[] { DateTime.Parse("03.02.2015"), DateTime.Parse("03.03.2015"), DateTime.Parse("01.05.2015") };

        while (currentDay <= inputDay)
        {
            if (((int)currentDay.DayOfWeek <= 5) && ((int)currentDay.DayOfWeek > 0) && (Array.IndexOf(offDays, currentDay) < 0))
            {
                countWorkDays++;
            }
            currentDay = currentDay.AddDays(1);
        }

        return countWorkDays;
    }

    static void Main()
    {
        Console.WriteLine("Enter a day:");
        DateTime inputDay = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("The number of work days is {0}", WorkDays(inputDay));
    }
}