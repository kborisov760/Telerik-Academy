namespace StudentClass.Exceptions
{
    using System;
    public class InvalidEmailAddressException : ApplicationException
    {
        public InvalidEmailAddressException(string message)
            : base(message) { }
    }
}