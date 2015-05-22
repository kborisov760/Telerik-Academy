namespace Shapes.Classes
{
    using System;
    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height)
        {
            this.Witdth = width;
            this.Height = height;
        }

        public override decimal CalculateSurface()
        {
            decimal surface = (this.Witdth * this.Height) / 2;
            return surface;
        }
    }
}
