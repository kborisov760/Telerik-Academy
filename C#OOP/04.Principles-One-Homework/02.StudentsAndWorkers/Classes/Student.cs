namespace StudentsAndWorkers.Classes
{
    using System;
    using System.Collections.Generic;
    public class Student : Human
    {
        private ushort studentGrade;

        public Student(string firstName, string lastName, ushort studentGrade)
            : base(firstName, lastName)
        {
            this.StudentGrade = studentGrade;
        }

        public ushort StudentGrade { get; set; }

        public override string ToString()
        {
            return String.Format("First name: {0} | Last name: {1} | Grade: {2}", this.FirstName, this.LastName, this.StudentGrade);
        }
    }
}
