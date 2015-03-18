namespace MobileDevice
{
    using System;
    using System.Collections.Generic;
    public class Gsm
    {
        //Fields:

        private string deviceModel;
        private string deviceManufacturer;
        private decimal devicePrice;
        private Battery gsmBattery;
        private Display gsmDisplay;
        
        private readonly string deviceOwner;
        private static IphoneClass iPhone4s = new IphoneClass();
        private const ushort SECONDS_IN_MINUTE = 60;
        private decimal price;

        //Constructors:

        public Gsm()
        {
            this.GsmBattery = null;
            this.HistoryList = new List<Call>();
        }

        public Gsm(string model, string manufacturer)
            : this()
        {
            this.DeviceModel = model;
            this.DeviceManuf = manufacturer;
        }

        public Gsm(string model, string manufacturer, BatteryType batteryModel, float displaySize, string displayColors)
            : this(model, manufacturer)
        {
            this.GsmBattery = new Battery(batteryModel);
            this.GsmDisplay = new Display(displaySize, displayColors);
        }

        //Properties:

        public static IphoneClass IPhone4S { get { return iPhone4s; } }
        public List<Call> HistoryList;

        public Battery GsmBattery { get { return this.gsmBattery; } set { this.gsmBattery = value; } }
        public Display GsmDisplay { get { return this.gsmDisplay; } set { this.gsmDisplay = value; } }

        public string DeviceModel
        {
            get { return this.deviceModel; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone model can not be empty!");
                }
                try
                {
                    this.deviceModel = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Wrong value!");
                }
            }
        }

        public string DeviceManuf
        {
            get { return this.deviceManufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Phone manufacturer can not be empty!");
                }
                try
                {
                    this.deviceManufacturer = value;
                }
                catch (Exception)
                {
                    throw new ArgumentException("Wrong value!");
                }
            }
        }

        public decimal Price
        {
            get { return this.devicePrice; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Price cannot be negativ!");
                    }
                    this.devicePrice = value;
                }
                catch (Exception)
                {
                    throw new Exception("Some error has occured!");
                }
            }
        }

        public BatteryType BatteryType { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get { return this.gsmBattery; } set { this.gsmBattery = value; } }
        public Display Display { get { return this.gsmDisplay; } set { this.gsmDisplay = value; } }

        //Methods:

        public override string ToString()
        {
            Console.WindowWidth = 120;
            string returnString = " Manuf.: " + this.DeviceManuf + ", Model: " + this.DeviceModel + ", Owner: " + this.Owner;
            if (this.GsmBattery != null)
            {
                returnString += "\n     Battery Params: (" + this.GsmBattery.ToString() + ")";
            }
            if (this.GsmDisplay != null)
            {
                returnString += "\n     Display Params: (" + this.GsmDisplay.ToString() + ")";
            }
            return returnString;
        }

        public void AddCall(DateTime callTime, string callNumber, uint callDuiration, bool showMessage)
        { // adding calls to CallHistory
            try
            {
                this.HistoryList.Add(new Call(callTime, callNumber, callDuiration));
                if (showMessage)
                {
                    Console.WriteLine("New call added");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid call time Format or call duration. No call added !!!");
            }
        }
        public void ClearHistory()
        { // Clear CallHistory
            this.HistoryList.Clear();
            Console.WriteLine("Call history is now empty ...");
        }
        public int ClearHistory(float callDuration, bool clearType)
        { // Clear calls with specific duration
            // if clearType is true - clear all calls with duration more than first param, else with less ...
            int i = 0;
            int j = 0;
            if (HistoryList.Count == 0)
            {
                return j;
            }
            while (true)
            {
                if ((HistoryList[j].CallDuration >= callDuration && clearType)
                    ||
                    (HistoryList[j].CallDuration <= callDuration && (!clearType)))
                {
                    HistoryList.RemoveRange(j, 1);
                    i++;
                }
                else
                {
                    j++;
                }
                if (j >= HistoryList.Count)
                {
                    return i;
                }
            }
        }
        public void PrintCallHistory()
        {// Lists to the console the call history
            if (HistoryList.Count == 0)
            {
                Console.WriteLine("No calls ..."); ;
            }
            for (int i = 0; i < HistoryList.Count; i++)
            {
                Console.WriteLine("Call time: {0}, Phone: {1}, Call duration [s]: {2}",
                    HistoryList[i].TimeOfCall, HistoryList[i].DialedPhone, HistoryList[i].CallDuration);
            }
        }
        public decimal CalculateTotalPrice(decimal callPrice)
        {// calculates total amount of all calls
            decimal finalPrice = 0;
            if (HistoryList.Count > 0)
            {
                for (int i = 0; i < HistoryList.Count; i++)
                {
                    finalPrice += HistoryList[i].CallDuration * callPrice / SECONDS_IN_MINUTE;
                }
            }
            return finalPrice;
        }
    }
}
