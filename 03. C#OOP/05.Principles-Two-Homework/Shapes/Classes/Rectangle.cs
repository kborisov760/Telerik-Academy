namespace Shapes.Classes
{
    using System;
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height)
        {
            this.Witdth = width;
            this.Height = height;
        }

        public override decimal CalculateSurface()
        {
            decimal surface = this.Witdth * this.Height;
            return Math.Round(surface, 2);
        }
    }
}
