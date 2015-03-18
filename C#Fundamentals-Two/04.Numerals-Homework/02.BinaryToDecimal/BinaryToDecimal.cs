using System;
class BinaryToDecimal
{
    static string NumericSystem = "0123456789ABCDEF";
    static int ConvertToDecimal(string number, int fromSystem)
    {
        int sum = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            sum += (int)(NumericSystem.IndexOf(number[i]) * Math.Pow(fromSystem, number.Length - 1 - i));
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Choose numeric system:");
        int fromSystem = int.Parse(Console.ReadLine());
        Console.Write("Enter number to convert:");
        string number = Console.ReadLine();
        Console.WriteLine("Number in decimal is {0}", ConvertToDecimal(number, fromSystem));
    }
}