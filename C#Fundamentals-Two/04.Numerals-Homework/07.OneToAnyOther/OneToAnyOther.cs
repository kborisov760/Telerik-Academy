using System;
class OneToAnyOther
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

    static string ConvertAnyToAny(string number, int fromSystem, int toSystem)
    {
        int result = ConvertToDecimal(number, fromSystem);
        string finalRes = ConvertFromDecimal(result, toSystem);
        return finalRes;
    }

    static void Main()
    {
        Console.Write("Enter number to convert:");
        string number = Console.ReadLine();
        Console.Write("Convert from:");
        int fromSystem = int.Parse(Console.ReadLine());
        Console.Write("Convert to:");
        int toSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is {0}", ConvertAnyToAny(number, fromSystem, toSystem));
    }
}
