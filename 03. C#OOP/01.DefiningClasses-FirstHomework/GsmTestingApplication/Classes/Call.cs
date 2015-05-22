namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Call
    {
        private DateTime timeOfCall;
        private string dialedPhone;
        private uint callDuration;

        public Call()
        {
            this.TimeOfCall = DateTime.Now;
            this.DialedPhone = "";
            this.CallDuration = 0;
        }

        public Call(DateTime inputTime, string inputPhoneNumber, uint inputDuration)
        {
            this.TimeOfCall = inputTime;
            this.DialedPhone = inputPhoneNumber;
            this.CallDuration = inputDuration;
        }
        public DateTime TimeOfCall
        {
            get { return this.timeOfCall; }
            set
            {
                try
                {
                    this.timeOfCall = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException();
                }
            }
        }
        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 10)
                {
                    throw new ArgumentException();
                }
                this.dialedPhone = value;
            }
        }
        public uint CallDuration
        {
            get { return this.callDuration; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Must be a positive !!!");
                }
                else
                {
                    this.callDuration = value;
                }
            }
        }
    }
}
