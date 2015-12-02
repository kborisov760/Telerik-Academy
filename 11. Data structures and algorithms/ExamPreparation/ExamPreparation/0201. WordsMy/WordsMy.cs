namespace WordsMy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class WordsMy
    {
        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            var inputText = new List<string>();
            
            for (int i = 0; i < T; i++)
            {
                var currentLine = Console.ReadLine();
                inputText.Add(currentLine);
            }

            var splittedInputText = new List<string[]>();

            foreach (var line in inputText)
            {
                var currentLine = line.Split(new char[] { '/', '\\', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToArray();
                splittedInputText.Add(currentLine);
            }

            foreach (var item in splittedInputText)
            {
                Console.WriteLine(String.Join(", ", item));
                Console.WriteLine();
            }
        }
    }
}
