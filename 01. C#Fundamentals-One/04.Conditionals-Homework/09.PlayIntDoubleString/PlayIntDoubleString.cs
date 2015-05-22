//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Welcome! Please, make your choice: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1: Console.Write("Enter value: ");
                int valueInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Output: {0}", valueInt + 1);
                break;

            case 2: Console.Write("Enter value: ");
                double valueDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Output: {0}", valueDouble);
                break;
            
            case 3:
                Console.Write("Please enter a string: ");
                string inpStr = Console.ReadLine();
                Console.WriteLine(inpStr + '*');
                break;

            default: Console.WriteLine("Invalid input...");
                break;
        }
        Console.WriteLine("-----------------------------------");

    }
}