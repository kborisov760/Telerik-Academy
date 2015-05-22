namespace MobileDevice
{
    using System;
    using System.Text;
    public class IphoneClass
    {
        private const string MODEL = "IPhone 4S";
        private const string MANUF = "Apple";
        private const decimal PRICE = 450;
        private const float DISPLAY_SIZE = 4.0f;
        private const string DISPLAY_COLORS = "16M";
        private const BatteryType BATTERY_TYPE = BatteryType.LiIon;

        private Battery battery = new Battery(BATTERY_TYPE, DateTime.Parse("12:00"), DateTime.Parse("7:00"));
        private Display display = new Display(DISPLAY_SIZE, DISPLAY_COLORS);

        public string ModelName { get { return MODEL; } }
        public string ManufName { get { return MANUF; } }
        public decimal Price { get { return PRICE; } }
        public Battery Battery { get { return this.battery; } }
        public Display Display { get { return this.display; } }

        public override string ToString()
        {
            Console.WindowWidth = 120;
            string returnString = " Manuf.: " + this.ManufName + ", Model: " + this.ModelName;
            returnString += "\n     Battery Params: (" + this.Battery.ToString() + ")";
            returnString += "\n     Display Params: (" + this.Display.ToString() + ")";
            return returnString;
        }
    }
}
