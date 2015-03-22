using System;
namespace PointGenerator.Classes
{
    public static class CalculateDistance
    {
        public static double DistanceCalculation(Point3D firstPoint, Point3D secondPoint)
        {
            Point3D pointOne = new Point3D(firstPoint.X, firstPoint.Y, firstPoint.Z);
            Point3D pointTwo = new Point3D(secondPoint.X, secondPoint.Y, secondPoint.Z);
            double distance =  Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) 
                                       + Math.Pow(pointOne.Y - pointTwo.Y, 2) 
                                       + Math.Pow(pointOne.Z - pointTwo.Z, 2));
            return distance;
        }
    }
}
