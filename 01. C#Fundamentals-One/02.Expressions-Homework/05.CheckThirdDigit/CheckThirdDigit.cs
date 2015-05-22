//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number to check: ");
        int input = int.Parse(Console.ReadLine());

        string outstring;
        outstring = ((input / 100) % 10 == 7) ? "The third digit is 7." : "The third digit isn't 7.";
        Console.WriteLine(outstring);
    }
}
