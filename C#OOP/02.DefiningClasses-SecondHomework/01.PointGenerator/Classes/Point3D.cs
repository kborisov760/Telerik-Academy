namespace PointGenerator.Classes
{   
    public struct Point3D
    {
        private static readonly Point3D startOfCoordinateSystem = new Point3D();

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        /// <summary>
        /// Overriding "ToString()" property for printing point
        /// </summary>
        
        public override string ToString()
        {
            return string.Format("Point: [{0},{1},{2}]", X, Y, Z);
        }

        /// <summary>
        /// Public property for the static Point3D startOfCoordinateSystem
        /// </summary>
        
        public static Point3D StartPoint
        {
            get { return startOfCoordinateSystem; }
        }
    }
}
