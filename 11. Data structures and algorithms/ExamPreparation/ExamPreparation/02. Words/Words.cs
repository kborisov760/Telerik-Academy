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

            HashSet<CheckableWord> wordHash = new HashSet<CheckableWord>();

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
                        if ((!wordHash.Any(w => w.Text == wordToAdd)) && (wordToAdd.Length > 0))
                        {
                            wordHash.Add(new CheckableWord(wordToAdd));
                        }
                        word.Clear();

                    }
                }

                wordToAdd = word.ToString();

                if ((!wordHash.Any(w => w.Text == wordToAdd)) && (wordToAdd.Length > 0))
                {
                    wordHash.Add(new CheckableWord(wordToAdd));
                }

            }

            Console.WriteLine();

            //foreach (var item in wordHash)
            //{
            //    Console.WriteLine(item.Text);
            //}

            Console.WriteLine();

            int M = int.Parse(Console.ReadLine());

            HashSet<string> SearchedWords = new HashSet<string>();

            for (int i = 0; i < M; i++)
            {
                string originalSearchWord = Console.ReadLine();
                string newSearchWord = originalSearchWord.ToLower();
                SearchedWords.Add(String.Format("{0} -> {1}",
                    originalSearchWord,
                    wordHash.Where(w => w.CheckIfAll(newSearchWord)).Count()));

            }

            foreach (var item in SearchedWords)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public class CheckableWord
        {
            public string Text { get; set; }

            public CheckableWord(string text)
            {
                this.Text = text;
            }

            public bool CheckIfAll(string word)
            {
                foreach (var symbol in word)
                {
                    if (!this.Text.Contains(symbol))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

    }

    //11.2012-Algo

}