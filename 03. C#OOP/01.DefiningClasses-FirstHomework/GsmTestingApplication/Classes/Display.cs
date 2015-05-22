namespace MobileDevice
{
    using System;
    public class Display
    {
        private float displaySize;
        private string displayColors;


        public Display()
        {

        }
        public Display(float size, string colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public float Size
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value < 1.0f || value > 6.0f)
                {
                    throw new ArgumentOutOfRangeException("Size could not be less than 1 or more than 6!");
                }
                this.displaySize = value;
            }
        }

        public string Colors
        {
            get
            {
                return this.displayColors;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Invalid value of display colors!");
                }
                this.displayColors = value;
            }
        }

        public override string ToString()
        {
            string returnString = "Size: " + this.displaySize +
                ", Colors: " + this.displayColors;
            return returnString;
        }
    }
}
