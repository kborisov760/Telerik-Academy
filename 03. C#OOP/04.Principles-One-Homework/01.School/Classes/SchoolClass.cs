namespace School.Classes
{
    using System;
    using Generators;
    using System.Collections.Generic;
    using System.Linq;
    public class SchoolClass
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string classUniqueNumber;

        public SchoolClass()
        {
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
            this.classUniqueNumber = IdGenerator.GenerateClassID();
        }

        public string ClassID { get { return this.classUniqueNumber; } }

        public void AddStudentsInClass(Student currentStudent)
        {
            students.Add(currentStudent);
        }

        public void AddTeacherForTheClass(Teacher currentTeacher)
        {
            teachers.Add(currentTeacher);
        }

        public List<Teacher> GetTeachersFromClass()
        {
            return this.teachers;
        }

        public Teacher GetTeacherFromClassByName(string firstName, string lastName)
        {
            var teacher = this.teachers.FirstOrDefault(x => x.FirstName.Equals(firstName) && x.LastName.Equals(lastName));
            return (Teacher)teacher;
        }

        public void PrintClass(SchoolClass currentClass)
        {
            Console.WriteLine("Class ID: {0}", currentClass.ClassID);
            Console.WriteLine("Teacher(s):");
            Console.WriteLine("-----------");
            foreach (var teacher in teachers)
            {
                Console.WriteLine("First name: {0} \nLast name: {1} \nDisciplines: {2}",
                                    teacher.FirstName, teacher.LastName, Teacher.GetTeacherDisciplinesFromList(teacher.TeacherDiscipline));
                Console.WriteLine("-----------");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("Student(s):");
            Console.WriteLine("-----------");
            foreach (var student in students)
            {
                Console.WriteLine("First name: {0} \nLast name: {1} \nID: {2}",
                                    student.FirstName, student.LastName, student.StudentID);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}
