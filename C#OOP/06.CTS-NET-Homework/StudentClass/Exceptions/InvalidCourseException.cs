namespace StudentClass.Exceptions
{
    using System;
    public class InvalidCourseException : ApplicationException
    {
        public InvalidCourseException(string message)
            : base(message) { }
    }
}