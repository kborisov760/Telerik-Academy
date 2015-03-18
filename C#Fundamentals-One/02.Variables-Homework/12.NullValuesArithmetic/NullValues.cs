//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.

using System;
using System.Text;

class NullValues
{
    static void Main()
    {
        int? intNumber = null;
        //double? doubleNumber = null;
        //Console.WriteLine("Firt number value = {0}", intNumber.Value);
        //Console.WriteLine("Second number value = {1}", doubleNumber.Value);
        //Console.WriteLine(".........");
        //intNumber = 5;
        //doubleNumber = 6.3D;
        //Console.WriteLine("First number value after assignment = {0}", intNumber);
        //Console.WriteLine("Second number value after assignment = {1}", doubleNumber);

        if (intNumber.HasValue)
        {
            Console.WriteLine("Firt number value = {0}", intNumber.Value);
        }
        else
        {
            Console.WriteLine("This number does not have value!");
        }
    }
}
