namespace XMLProcessing
{
    using System;

    public class Person
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Person() { }

        public Person(string FullName, string PhoneNumber, string Address)
        {
            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public override string ToString()
        {
            return String.Format("Full name: {0}\nPhone number: {1}\nAddress: {2}\n",
                this.FullName, this.PhoneNumber, this.Address);
        }
    }
}
