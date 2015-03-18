namespace MobileDevice
{
    using System;
    public class Battery
    {
        private DateTime batteryHoursIdle = DateTime.Parse("03:00");
        private DateTime batteryHoursTalk = DateTime.Parse("01:00");
        private BatteryType batteryModel = BatteryType.LiIon;


        public Battery()
        {

        }

        public Battery(BatteryType batteryModel)
        {
            this.Type = batteryModel;
        }

        public Battery(BatteryType batteryModel, DateTime hoursIdle, DateTime hoursTalk) : this(batteryModel)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType Type
        {
            get { return batteryModel; }
            set { this.batteryModel = value; }
        }

        public DateTime HoursIdle
        {
            get { return this.batteryHoursIdle; }
            set
            {
                try
                {
                    if (value.Hour < 1 || value.Hour > 12)
                    {
                        Console.WriteLine("Value is assigned but it's suspicious.");
                    }
                    this.batteryHoursIdle = value;
                }
                catch (Exception)
                {

                    throw new ArgumentException("Invalid time value!");
                }
            }
        }

        public DateTime HoursTalk
        {
            get { return this.batteryHoursTalk; }
            set
            {
                try
                {
                    this.batteryHoursTalk = value;
                }
                catch (Exception)
                {

                    throw new FormatException("Cannot parse time, it is not in the correct format!");
                }
            }
        }

        public override string ToString()
        {
            string returnString = "Type: " + this.batteryModel +
                ", Idle time: " + this.HoursIdle.ToShortTimeString() +
                ", Talk time: " + this.HoursTalk.ToShortTimeString();
            return returnString;
        }
    }
}
