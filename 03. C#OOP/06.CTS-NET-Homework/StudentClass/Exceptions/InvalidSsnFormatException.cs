namespace StudentClass.Exceptions
{
    using System;
    public class InvalidSsnFormatException : ApplicationException
    {
        public InvalidSsnFormatException(string message, string defalutFormat)
            : base(message) { }
    }
}
