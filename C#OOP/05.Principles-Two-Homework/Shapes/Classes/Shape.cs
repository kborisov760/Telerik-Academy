namespace Shapes.Classes
{
    public abstract class Shape
    {
        public decimal Witdth { get; set; }
        public decimal Height { get; set; }

        public virtual decimal CalculateSurface()
        {
            return this.Witdth * this.Height;
        }
    }
}
