using System;
class BinaryToHexadecimal
{
    static string NumericSystem = "0123456789ABCDEF";
    static string[] BinaryNumSystem = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };

    static void Main()
    {
        Console.Write("Enter number in binary system:");
        string binNum = Console.ReadLine();
        string sum = "";
        if (binNum.Length % 4 != 0)
        {
            binNum = new string('0', 4 - (binNum.Length % 4)) + binNum;
        }
        for (int i = 0; i < binNum.Length / 4; i++)
        {
            int index = Array.IndexOf(BinaryNumSystem, binNum.Substring(4 * i, 4));
            sum = sum + NumericSystem[index];
        }
        Console.WriteLine("The number in hexadecimal system is {0}", sum);
    }
}