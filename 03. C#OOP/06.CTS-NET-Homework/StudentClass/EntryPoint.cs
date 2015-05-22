namespace StudentClass
{
    using Classes;
    using Enumerations;
    using System;
    using System.Net.Mail;
    public class EntryPoint
    {
        public static void Main()
        {
            //Student test

            MailAddress mail = new MailAddress("ben@contoso.com", "Ben Miller");
            Student firstStudent = new Student("Pesho", "Goshov", "Peshov", "333-22-8976", "Sofia, Bulgaria", "(359) 885-1234", mail, "IT",
                                                Speciality.InformationTechnology, University.NewBulgarianUniversity, Faculty.FacultyOfMathematicsAndInformatics);
            firstStudent.CoursesList.Add(Courses.ASPdotNET);
            firstStudent.CoursesList.Add(Courses.OOP);

            Student secondStudent = (Student)firstStudent.Clone();

            secondStudent.CoursesList[1] = Courses.JavaScript;

            Console.WriteLine(String.Join(", ", firstStudent.CoursesList));
            Console.WriteLine(String.Join(", ", secondStudent.CoursesList));

            //Person test

            Person ivanPerson = new Person("Ivan", "19");
            Console.WriteLine(ivanPerson.ToString());

            //BitArray test

            BitArray arr = new BitArray(7u);
            BitArray arr2 = new BitArray(8u);

            Console.WriteLine(arr);
            arr[1] = 0;
            Console.WriteLine(arr);

            Console.WriteLine(arr == arr2);
            Console.WriteLine(arr.Equals(arr));
            Console.WriteLine(arr != arr2);
        }
    }
}
