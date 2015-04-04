namespace StudentClass.Exceptions
{
    using System;
    public class InvalidPhoneNumberException : ApplicationException
    {
        public InvalidPhoneNumberException(string message, string defaulfFormat)
            : base(message) { }
    }
}