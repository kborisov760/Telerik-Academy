namespace StudentClass.Classes
{
    using Exceptions;
    using System;
    using System.Linq;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    using Enumerations;
    using System.Reflection;
    public class Student : IComparable<Student>, ICloneable
    {

        /// <summary>
        /// SSN default valid format: XXX-XX-XXXX where "X" are digits
        /// </summary>
        private string SSN_VALIDATOR_FORMAT = "^(?:[0-9]{3})-(?:[0-9]{2})-(?<last>[0-9]{4})$";
        /// <summary>
        /// Mobile phone number default valid format: "(XXX) XXX-XXXX" where "X" are digits
        /// </summary>
        private string PHONE_VALIDATOR_FORMAT = @"^\(\d{3}\) \d{3}-\d{4}$";

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private MailAddress email;
        private string course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        private Student() { CoursesList = new List<Courses>(); }
        public Student(string fName, string mName, string lName, string ssn)
            : this()
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
        }

        public Student(string fName, string mName, string lName, string ssn, string address, string phone, MailAddress email, string course, Speciality spec, University uni, Faculty facul)
            : this(fName, mName, lName, ssn)
        {
            this.PermanentAddress = address;
            this.MobilePhone = phone;
            this.EmailAddress = email;
            this.Course = course;
            this.Speciality = spec;
            this.University = uni;
            this.Faculty = facul;
        }

        private void CheckName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("This name cannot be empty!");
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                CheckName(value);
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                CheckName(value);
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                CheckName(value);
                this.lastName = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            set
            {
                Regex testSSN = new Regex(SSN_VALIDATOR_FORMAT, RegexOptions.IgnorePatternWhitespace);
                if (!testSSN.IsMatch(value))
                {
                    throw new InvalidSsnFormatException("Cannot parse SSN!", SSN_VALIDATOR_FORMAT);
                }
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidAddressException("Address cannot be empty");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                Regex testPhone = new Regex(PHONE_VALIDATOR_FORMAT);
                if (!testPhone.IsMatch(value))
                {
                    throw new InvalidPhoneNumberException("Cannot parse phone number!", PHONE_VALIDATOR_FORMAT);
                }

                this.mobilePhone = value;
            }
        }

        public MailAddress EmailAddress { get; set; }

        public string Course
        {
            get { return this.course; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new InvalidCourseException("Course cannot be empty!");
                }

                this.course = value;
            }
        }

        public Speciality Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }

        public int CompareTo(Student otherStudent)
        {
            int result = this.FirstName.CompareTo(otherStudent.FirstName);
            if (result == 0)
            {
                result = this.SSN.CompareTo(otherStudent.SSN);
            }

            return result;
        }

        public List<Courses> CoursesList;

        public object Clone()
        {
            var newStudent = new Student();
            PropertyInfo[] propList = newStudent.GetType().GetProperties();

            foreach (var prop in propList)
            {
                if ((prop.GetType() != typeof(List<Courses>)) || (prop.GetType() != typeof(MailAddress)))
                {
                    prop.SetValue(newStudent, prop.GetValue(this));
                }
            }

            newStudent.CoursesList = new List<Courses>();
            newStudent.EmailAddress = new MailAddress(this.EmailAddress.Address);
            if (this.CoursesList != null)
            {
                for (int i = 0; i < this.CoursesList.Count; i++)
                {
                    newStudent.CoursesList.Add(this.CoursesList[i]);
                }
                //newStudent.CoursesList = this.CoursesList;
            }

            return newStudent as object;
        }
    }
}
