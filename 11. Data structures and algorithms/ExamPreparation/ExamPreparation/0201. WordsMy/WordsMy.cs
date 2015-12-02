namespace WordsMy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Text;

    public class WordsMy
    {
        static Dictionary<string, int> words = new Dictionary<string, int>();

        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder inputText = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                var currentLine = Console.ReadLine();
                inputText.Append(currentLine);
            }
            
            var splittedInputText = GetWords(inputText.ToString());
            var uniqueWords = new HashSet<string>();

            foreach (var word in splittedInputText)
            {
                uniqueWords.Add(word);
            }



            foreach (var item in uniqueWords)
            {
                Console.WriteLine(String.Join(", ", item));
            }
        }

        static bool CheckWord(string word, string original)
        {
            int counter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if(original.Contains(word[i]))
                {
                    counter++;
                }
            }

            if(counter == word.Length)
            {
                return true;
            }

            return false;
        }

        static int CountOccurences(string word, string[] input)
        {
            foreach (var item in input)
            {
                if(CheckWord(word, item) == true)
                {
                    //TODO: Implement logic for counting all occurences of a single word using global counter
                }
            }

            return 0;
        }

        static string[] GetWords(string input)
        {
            MatchCollection matches = Regex.Matches(input, @"\b[\w']*\b");

            var words = from m in matches.Cast<Match>()
                        where !string.IsNullOrEmpty(m.Value)
                        select TrimSuffix(m.Value);

            return words.ToArray();
        }

        static string TrimSuffix(string word)
        {
            int apostropheLocation = word.IndexOf('\'');
            if (apostropheLocation != -1)
            {
                word = word.Substring(0, apostropheLocation);
            }

            return word;
        }
    }
}
