namespace StudentsAndWorkers
{
    using Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("List of students:");
            Console.WriteLine("------------------------------------------");
            Random classGen = new Random();
            List<Student> students = new List<Student>();
            students.Add(new Student("George", "Georgiev", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Stefan", "Stafanov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Yordan", "Yordanov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Damyan", "Damyanov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Sevdalin", "Peshev", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Pesho", "Sevdalinov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Goran", "Yotov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Haivan", "Sokolov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Sokol", "Haivanov", (ushort)classGen.Next(1, 13)));
            students.Add(new Student("Druvcho", "Durvarov", (ushort)classGen.Next(1, 13)));

            var sortedStudent = students.OrderBy(x => x.StudentGrade);
            foreach (var item in sortedStudent)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("List of workers:");
            Console.WriteLine("------------------------------------------");
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Losh", "Goshov", 290, 5));
            workers.Add(new Worker("Gosh", "Loshov", 600, 7));
            workers.Add(new Worker("Pesho", "Goshov", 500, 12));
            workers.Add(new Worker("Gosho", "Peshov", 368, 5));
            workers.Add(new Worker("Dinko", "Vbagajnikov", 825, 7));
            workers.Add(new Worker("Sensei", "Osmanov", 123, 5));
            workers.Add(new Worker("Djordjano", "Iluminatov", 751, 2));
            workers.Add(new Worker("Damyan", "Ovanezov", 740, 3));
            workers.Add(new Worker("Marzipan", "Petkov", 690, 7));
            workers.Add(new Worker("Yordan", "Dobrev", 479, 5));

            var sortedWorkers = workers.OrderBy(x => x.MoneyPerHour(x));
            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("List of people, sorted by name:");
            Console.WriteLine("------------------------------------------");

            var mergedList = new List<Human>();
            foreach (var item in sortedStudent)
            {
                mergedList.Add(item);
            }

            foreach (var item in sortedWorkers)
            {
                mergedList.Add(item);
            }

            var sortedByName = mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var item in sortedByName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
