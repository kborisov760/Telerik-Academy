namespace WordsKenov_2013
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());

            HashSet<string> wordHash = new HashSet<string>();

            StringBuilder word = new StringBuilder();

            string line;
            string wordToAdd;

            for (int i = 0; i < N; i++)
            {
                line = Console.ReadLine().ToLower();
                word.Clear();
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] >= 'a' && line[j] <= 'z')
                    {
                        word.Append(line[j]);
                    }
                    else
                    {

                        wordToAdd = word.ToString();
                        if (wordToAdd.Length > 0)
                        {
                            wordHash.Add(wordToAdd);
                        }

                        word.Clear();
                    }
                }

                wordToAdd = word.ToString();
                if (wordToAdd.Length > 0)
                {
                    wordHash.Add(wordToAdd);
                }
            }


            int M = int.Parse(Console.ReadLine());

            HashSet<string> SearchedWords = new HashSet<string>();

            for (int i = 0; i < M; i++)
            {
                string originalSearchWord = Console.ReadLine();
                string newSearchWord = originalSearchWord.ToLower();
                SearchedWords.Add(String.Format("{0} -> {1}",
                    originalSearchWord,
                    wordHash.Where(w => CheckIfAll(newSearchWord, w)).Count()));
            }

            foreach (var item in SearchedWords)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static bool CheckIfAll(string inputWord, string mainWord)
        {
            foreach (var symbol in inputWord)
            {
                if (!mainWord.Contains(symbol))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
