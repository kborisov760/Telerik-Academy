namespace School.Classes
{
    using System;
    public abstract class Person
    {
        /// <summary>
        /// Public class "Person" which is inherited by the Student class and by the Teacher class;
        /// Represents base properties for every person - First name and last name;
        /// Validation included
        /// </summary>

        private string firstName;
        private string lastName;

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("First name cannot be empty!");
                    }

                    this.firstName = value;
                }
                catch (Exception)
                {
                    throw new FormatException("First name is not in the correct format!");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Last name cannot be empty!");
                    }

                    this.lastName = value;
                }
                catch (Exception)
                {
                    throw new FormatException("Last name is not in the correct format!");
                }
            }
        }
    }
}
