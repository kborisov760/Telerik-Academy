namespace HighQualityMethods
{
    using System;

    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate, secondDate;
            try
            {
                firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
                secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            }
            catch (Exception)
            {
                throw new FormatException("Some of the dates are not in the correct format!");
            }

            return firstDate < secondDate;
        }
    }
}