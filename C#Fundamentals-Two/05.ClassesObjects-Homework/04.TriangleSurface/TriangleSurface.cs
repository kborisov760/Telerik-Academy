//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
class TriangleSurfaceProgram
{
    static double TriangleSurface(double aSide, double altitudeA)
    {
        double result = (aSide * altitudeA) / 2;
        return result;
    }

    static double TriangleSurface(double aSide, double bSide, double cSide)
    {
        double result = 0;
        double s = (aSide + bSide - cSide)/2;
        result = Math.Sqrt(s*(s-aSide)*(s-bSide)*(s-cSide));
        return result;
    }
    static double TriangleSurface(double aSide, double bSide, int angle)
    {
        double result = 0;
        result = (aSide*bSide*Math.Sin(angle))/2;
        return result;
    }
    static void Main()
    {
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;
        double altitude = 0;
        int angle = 0;

        while (true)
        {
            Console.WriteLine("Triangle Surface");
            Console.WriteLine("-------------------");
            Console.WriteLine("Surface by side and altitude --> press 1");
            Console.WriteLine("Surface by three sides --> press 2");
            Console.WriteLine("Surface by two sides and angle between them --> press 3");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            switch (key)
            {
                case 1:
                    Console.Write("Side size: ");
                    sideA = int.Parse(Console.ReadLine());
                    Console.Write("Altitude: ");
                    altitude = int.Parse(Console.ReadLine());
                    Console.WriteLine("S = {0}", Math.Round(TriangleSurface(sideA, altitude), 2));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Side size: ");
                    sideA = int.Parse(Console.ReadLine());
                    Console.Write("Side size: ");
                    sideB = int.Parse(Console.ReadLine());
                    Console.Write("Side size: ");
                    sideC = int.Parse(Console.ReadLine());
                    Console.WriteLine("S = {0}", Math.Round(TriangleSurface(sideA, sideB, sideC), 2));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Side size: ");
                    sideA = int.Parse(Console.ReadLine());
                    Console.Write("Side size: ");
                    sideB = int.Parse(Console.ReadLine());
                    Console.Write("Angle between them: ");
                    angle = int.Parse(Console.ReadLine());
                    Console.WriteLine("S = {0}", Math.Round(TriangleSurface(sideA, sideB, angle), 2));
                    Console.ReadKey();
                    break;
                default: Console.WriteLine("Invalid input, please try again!");
                    break;
            }

            Console.Clear();
        }
    }
}
