namespace ExtensionMethods
{
    using Classes;
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    class TestClassesMain
    {
        static void Main()
        {
            //Testing stringbuilder extension method

            StringBuilder inPut = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                inPut.Append((char)(i + 65));
            }

            string outPut = inPut.Substring(0, 2);
            Console.WriteLine(outPut);

            //Testing Student class

            List<Student> students = new List<Student>
            {
                new Student 
                {
                    Id = 1, 
                    FirstName = "Ivan", 
                    LastName = "Petrov", 
                    Age = 21,
                    Group = new Group(1, Department.Mathematics),
                    FacNumber = "123406",
                    Email = "ivanpetrov@gmail.com",
                    PhoneNumber = "052125856",
                    Marks = new List<int>{2,4,4,3,2,5}},
                
                new Student
                {
                    Id = 2, 
                    FirstName = "Peter", 
                    LastName = "Ivanov", 
                    Age = 19,
                    Group = new Group(2, Department.Mathematics),
                    FacNumber = "654305",
                    Email = "peterivanov@abv.bg",
                    PhoneNumber = "026597844",
                    Marks = new List<int>{5,5,3,6,2,4}},
                
                new Student
                {
                    Id = 3, 
                    FirstName = "George", 
                    LastName = "Stoyanov", 
                    Age = 17,
                    Group = new Group(1, Department.Biogoly),
                    FacNumber = "568106",
                    Email = "georgestoyanov@abv.bg",
                    PhoneNumber = "025987498",
                    Marks = new List<int>{4,4,3,2,5,5}},
        
                new Student
                {
                    Id = 4, 
                    FirstName = "Stoyan", 
                    LastName = "Georgiev", 
                    Age = 25,
                    Group = new Group(3, Department.Physics),
                    FacNumber = "936706",
                    Email = "stoyangeorgiev@yahoo.com",
                    PhoneNumber = "043633020",
                    Marks = new List<int>{6,6,5,2,4,5}}};

            //All queries for student class

            var studentSortName = students.Where(st => st.FirstName.CompareTo(st.LastName) == -1).ToList();
            Console.WriteLine("01. Students with first name before last name:");
            Console.WriteLine("------------------------------------");
            Student.Print(studentSortName);
            Console.WriteLine("------------------------------------");

            var studentAgeLimit = students.Where(st => st.Age >= 18 && st.Age <= 24).Select(st => new { fName = st.FirstName, lName = st.LastName }).ToList();
            Console.WriteLine("02. Students with age between 18 and 24:");
            Console.WriteLine("------------------------------------");
            foreach (var item in studentAgeLimit)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

            var orderedStudents = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).ToList();
            Console.WriteLine("03. Ordered students by name:");
            Console.WriteLine("------------------------------------");
            Student.Print(orderedStudents);
            Console.WriteLine("------------------------------------");

            var studentsByEmail = students.Where(x => x.Email.Substring(x.Email.Length - 7, 7) == "@abv.bg").ToList();
            Console.WriteLine("04. Select students by email on \"@abv.bg\":");
            Console.WriteLine("------------------------------------");
            Student.Print(studentsByEmail);
            Console.WriteLine("------------------------------------");

            var studentsByPhone = students.Where(x => x.PhoneNumber.Substring(0, 2) == "02").ToList();
            Console.WriteLine("05. Select students by phone number in Sofia:");
            Console.WriteLine("------------------------------------");
            Student.Print(studentsByPhone);
            Console.WriteLine("------------------------------------");

            var studentsByMarkSix = students.Where(st => st.Marks.Any(m => m == 6)).ToList();
            Console.WriteLine("06. Select students by mark of six(6):");
            Console.WriteLine("------------------------------------");
            Student.Print(studentsByMarkSix);
            Console.WriteLine("------------------------------------");

            var studentsByTwoMarks = students.Where(st => st.Marks.Count(m => m == 2) == 2).ToList();
            Console.WriteLine("07. Select students by two marks of poor(2):");
            Console.WriteLine("------------------------------------");
            Student.Print(studentsByTwoMarks);
            Console.WriteLine("------------------------------------");

            var allStudentMarks = students.Where(st => st.FacNumber.Substring(4, 2) == "06").ToList();
            Console.WriteLine("08. Select students by year 2006:");
            Console.WriteLine("------------------------------------");
            foreach (var item in allStudentMarks)
            {
                Console.WriteLine(String.Join(", ", item.Marks));
            }
            Console.WriteLine("------------------------------------");

            var allMathStudents = students.Where(st => st.Group.DepartmentName == Department.Mathematics).ToList();
            Console.WriteLine("09. Select students by department of mathematics:");
            Console.WriteLine("------------------------------------");
            Student.Print(allMathStudents);
            Console.WriteLine("------------------------------------");
            
            //Given array of integers --> Printing devisible by 7 and 3 with LINQ
            
            Console.WriteLine("------------------------------------");
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            var numberDevisible = numbers.Where(x => x % 7 == 0 && x % 3 == 0).ToList();
            foreach (var number in numberDevisible)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("------------------------------------");

            //Using implemented method to return the longest string 

            var strings = new List<string> { "bla", "bla", "blabla", "blablablablabla", "bla", "blablablabla", "blabla", "blabla" };
            var outLongestString = LongestString(strings);
            Console.WriteLine(outLongestString);

            var timer = new Timer(1);
            timer.Methods = Tick;
            timer.Methods += Tock;
            timer.ExecuteMethods();
        }

        /// <summary>
        /// Implementing method to return the longest string in sequnece
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        
        public static string LongestString(List<string> input)
        {
            var longestString = input.OrderByDescending(x => x.Length).First().ToString();
            return longestString;
        }

        public static void Tick()
        {
            Console.WriteLine("Tick");
        }
        public static void Tock()
        {
            Console.WriteLine("Tock");
        }
    }
}
