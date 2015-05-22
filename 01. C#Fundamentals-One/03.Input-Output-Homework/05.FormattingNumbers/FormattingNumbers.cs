using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int integerNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter first float number: ");
        float firstFloatNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second float number: ");
        float secondFloatNumber = float.Parse(Console.ReadLine());

        string integerNumberToHex = Convert.ToString(integerNumber, 16).ToUpper();
        string integerNumberToBinary = Convert.ToString(integerNumber, 2).PadLeft(10, '0');

        Console.WriteLine("{0} |{1}| {2:0.00}|{3:0.000} |", integerNumberToHex, integerNumberToBinary, firstFloatNumber, secondFloatNumber); 
    }
}
