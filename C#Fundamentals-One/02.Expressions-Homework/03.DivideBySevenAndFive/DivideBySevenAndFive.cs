//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter number to check: ");
        int input = int.Parse(Console.ReadLine());
        bool isDividable = false;
        if ((input % 7 == 0) && (input % 5 == 0))
        {
            isDividable = true;
            Console.WriteLine("Dividable by 7 and 5? {0}", isDividable);
        }
        else
        {
            Console.WriteLine("Dividable by 7 and 5? {0}", isDividable);
        }
    }
}
