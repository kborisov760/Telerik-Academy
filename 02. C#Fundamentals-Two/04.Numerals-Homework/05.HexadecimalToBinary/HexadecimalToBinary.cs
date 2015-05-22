using System;
class HexadecimalToBinary
{
    static string NumericSystem = "0123456789ABCDEF";
    static string[] BinaryNumSystem = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };

    static void Main()
    {
        Console.Write("Enter number in hexadecimal system:");
        string hexaNum = Console.ReadLine();
        string sum = "";
        for (int i = 0; i < hexaNum.Length; i++)
        {
            int index = NumericSystem.IndexOf(hexaNum[i]);
            sum = sum + BinaryNumSystem[index];
        }
        Console.WriteLine("The number in binary system is {0}", sum);
    }
}
