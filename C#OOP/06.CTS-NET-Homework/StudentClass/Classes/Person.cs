namespace StudentClass.Classes
{
    using System;

    public class Person
    {
        private string name;
        private string age;

        public Person(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            string output = string.Empty;
            output += String.Format("Name: {0}", this.Name);
            if (!String.IsNullOrEmpty(this.Age))
            {
                output += String.Format("; Age: {0}", this.Age);
            }

            return output;
        }
    }
}
