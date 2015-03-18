using System;
class DecimalToBinary
{
    static string NumericSystem = "0123456789ABCDEF";
    static string ConvertFromDecimal(int number, int toSystem)
    {
        string str = "";
        while (number > 0)
        {

            str = NumericSystem[number % toSystem] + str;
            number /= toSystem;
        }
        return str;
    }

    static void Main(string[] args)
    {
        Console.Write("Choose numeric system:");
        int toSystem = int.Parse(Console.ReadLine());
        Console.Write("Enter number to convert:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("New number is {0}", ConvertFromDecimal(number, toSystem));
    }
}