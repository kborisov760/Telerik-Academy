namespace StudentsAndWorkers.Classes
{
    using System;
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string fName, string lName)
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

        public override string ToString()
        {
            return String.Format("First name: {0} | Last name: {1}", this.FirstName, this.LastName);
        }
    }
}
