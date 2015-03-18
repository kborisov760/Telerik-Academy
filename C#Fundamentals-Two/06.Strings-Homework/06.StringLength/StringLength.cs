//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            StringBuilder append = new StringBuilder();
            if (text.Length < 20)
            {
                string asterix = new string('*', 20 - text.Length);
                Console.WriteLine(text + asterix);
            }
        }
    }
}
