//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class OrderWords
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> orderedWords = new List<string>();

            words = words.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", words));
            
        }
    }