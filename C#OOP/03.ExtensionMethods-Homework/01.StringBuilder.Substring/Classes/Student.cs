namespace ExtensionMethods.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ushort Age { get; set; }

        public string FacNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Id, this.FirstName, this.LastName);
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
