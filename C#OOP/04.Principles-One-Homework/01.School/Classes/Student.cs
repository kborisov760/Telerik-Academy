namespace School.Classes
{
    using System;
    using Generators;
    public class Student : Person
    {
        private uint uniqueNumber;

        public Student(string fName, string lName) : base(fName, lName)
        {
            this.uniqueNumber = IdGenerator.GenerateStudentID();
        }

        public uint StudentID { get { return this.uniqueNumber; } }

        public override string ToString()
        {
            return String.Format("First name: {0}; Last name: {1}; ID: {2}", this.FirstName, this.LastName, this.StudentID);
        }
    }
}
