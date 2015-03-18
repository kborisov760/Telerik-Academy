//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
//letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;
class EncodeDecode
{
    static void Main()
    {
        string str = Console.ReadLine();
        string cipher = "ab";
        ushort[] codedArray = new ushort[str.Length];
        StringBuilder decodedString = new StringBuilder(str.Length);
        for (int i = 0; i < str.Length; i++)
        {
            ushort curKey = (ushort)cipher[(i % cipher.Length)];
            codedArray[i] = (ushort)((ushort)str[i] ^ curKey);
            Console.WriteLine("{0:x4}", codedArray[i]);
        }
        for (int i = 0; i < str.Length; i++)
        {
            ushort curKey = (ushort)cipher[(i % cipher.Length)];
            decodedString.Append((char)((ushort)codedArray[i] ^ curKey));
        }
        Console.WriteLine(decodedString);
    }
}