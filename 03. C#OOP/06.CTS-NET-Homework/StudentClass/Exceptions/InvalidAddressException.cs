namespace StudentClass.Exceptions
{
    using System;
    public class InvalidAddressException : ApplicationException
    {
        public InvalidAddressException(string message)
            : base(message) { }
    }
}
