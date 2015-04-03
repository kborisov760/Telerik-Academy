namespace Shapes.Classes
{
    using System;
    public class Square : Shape
    {
        public Square(decimal width, decimal height)
        {
            this.Witdth = width;
            this.Height = width;
        }

        public override decimal CalculateSurface()
        {
            decimal surface = this.Witdth * this.Height;
            return Math.Round(surface, 2); 
        }
    }
}
