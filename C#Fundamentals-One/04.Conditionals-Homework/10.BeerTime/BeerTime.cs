//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
//according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        Console.Write("Please enter time to check: ");
        DateTime input = DateTime.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        string inputFormat = input.ToString(@"hh:mm tt", new CultureInfo("en-US"));
        string outstring = (input >= startTime || input <= endTime ) ? "Beer time" : "Non-beer time";
        Console.WriteLine(outstring);
    }
}
