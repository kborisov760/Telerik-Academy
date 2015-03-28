namespace School
{
    using System;
    using Classes;
    using System.Collections.Generic;

    class MainProgram
    {
        static void Main()
        {
            List<School> mySchools = new List<School>();
            mySchools.Add(new School("High school of mathematics"));
            Console.WriteLine("{0}", mySchools[0].ToString());
            List<SchoolClass> classes = new List<SchoolClass>();
            classes.Add(new SchoolClass());
            classes.Add(new SchoolClass());

            classes[0].AddTeacherForTheClass(new Teacher("Ivan", "Petrov"));
            classes[0].AddTeacherForTheClass(new Teacher("Stoyan", "Genov"));
            classes[1].AddTeacherForTheClass(new Teacher("Panayot", "Peev"));
            classes[1].AddTeacherForTheClass(new Teacher("Goran", "Penev"));
            classes[1].AddTeacherForTheClass(new Teacher("Dimcho", "Dinev"));

            var ivanPetrovTeacher = classes[0].GetTeacherFromClassByName("Ivan", "Petrov");
            ivanPetrovTeacher.AddDisciplinesForTeacherList(new Discipline(TeacherDisciplines.Biology, 5, 5));
            var stoyanGenovTeacher = classes[0].GetTeacherFromClassByName("Stoyan", "Genov");
            stoyanGenovTeacher.AddDisciplinesForTeacherList(new Discipline(TeacherDisciplines.Chemistry, 2, 1));

            var secondClassTeacher = classes[1].GetTeachersFromClass();
            secondClassTeacher[0].AddDisciplinesForTeacherList(new Discipline(TeacherDisciplines.ComputerSciences, 3, 2));
            secondClassTeacher[1].AddDisciplinesForTeacherList(new Discipline(TeacherDisciplines.Painting, 3, 4));
            secondClassTeacher[2].AddDisciplinesForTeacherList(new Discipline(TeacherDisciplines.Mathematics, 2, 5));


            classes[0].AddStudentsInClass(new Student("Kaloyan", "Dobrev"));
            classes[0].AddStudentsInClass(new Student("Dragan", "Kolev"));
            classes[0].AddStudentsInClass(new Student("Stefan", "Popov"));
            classes[0].AddStudentsInClass(new Student("Dobromir", "Pashov"));
            classes[0].AddStudentsInClass(new Student("Genadi", "Stoimenov"));

            classes[0].PrintClass(classes[0]);
        }
    }
}
