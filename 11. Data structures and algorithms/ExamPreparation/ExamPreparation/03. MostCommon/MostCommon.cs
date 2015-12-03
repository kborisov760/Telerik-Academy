namespace MostCommon
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class MostCommon
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var people = new HashSet<Person>();

            for (int i = 0; i < N; i++)
            {
                var line = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(line[0], line[1], int.Parse(line[2]), line[3], line[4], int.Parse(line[5])));
            }

            var listOfEverything = new List<string>();

            listOfEverything.Add(people
                .GroupBy(x => x.FirstName)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key)
                .FirstOrDefault());


            listOfEverything.Add(people.GroupBy(x => x.LastName)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key)
                .FirstOrDefault());

            listOfEverything.Add(people.GroupBy(x => x.YearOfBirth)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key.ToString())
                .FirstOrDefault());

            listOfEverything.Add(people.GroupBy(x => x.EyeColor)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key)
                .FirstOrDefault());

            listOfEverything.Add(people.GroupBy(x => x.HairColor)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key)
                .FirstOrDefault());

            listOfEverything.Add(people.GroupBy(x => x.Height)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select(x => x.Key.ToString())
                .FirstOrDefault());

            foreach (var list in listOfEverything)
            {
                Console.WriteLine(list.Trim());
            }
        }
    }

    public class Person
    {
        public Person(string fName, string lName, int birthYear, string eyeColor, string hairColor, int height)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.YearOfBirth = birthYear;
            this.EyeColor = eyeColor;
            this.HairColor = hairColor;
            this.Height = height;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }

        public int Height { get; set; }
    }
}