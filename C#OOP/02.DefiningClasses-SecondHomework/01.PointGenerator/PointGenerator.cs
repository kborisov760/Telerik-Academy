namespace PointGenerator
{
    using System;
    using Classes;
    using System.Collections.Generic;
    class PointGenerator
    {
        static void Main()
        {
            // Class Point3D examples
            Console.WindowHeight = 50;
            Point3D testPoint = new Point3D(4, 5, 6);
            Console.WriteLine(testPoint);
            Console.WriteLine(CalculateDistance.DistanceCalculation(testPoint, Point3D.StartPoint));

            // Class Path examples
            Path pointList = new Path();
            PathStorage.ReadPathFromFile("..\\..\\data.txt", pointList);
            pointList.Add(new Point3D(10, 11, 12));
            pointList.Add(new Point3D(13, 14, 15));
            pointList.Add(new Point3D(16, 17, 18));
            PathStorage.WritePathToFile("..\\..\\DataWrite.txt", pointList);

            // GenericList examples
            // List of Point3D elements
            GenericList<Point3D> myGeneric = new GenericList<Point3D>();
            for (int i = 0; i < 10; i++)
            {
                myGeneric.Add(new Point3D(i + 1, i + 2, i + 3));
            }
            myGeneric.Remove(7);
            myGeneric.Insert(new Point3D(98, 99, 100), 7);
            Console.WriteLine("\nMyGenericList of Point3D elements");
            Console.WriteLine(myGeneric);

            // List of float numbers
            GenericList<float> myGenericFloat = new GenericList<float>();
            for (int i = 0; i < 10; i++)
            {
                myGenericFloat.Add(i * 1.1f);
            }
            myGenericFloat.Remove(7);
            myGenericFloat.Insert(-100.98888f, 7);
            Console.WriteLine("\nMyGenericList of float numbers");
            Console.WriteLine(myGenericFloat);
            Console.WriteLine("Max value in float List is {0}", myGenericFloat.Max());
            Console.WriteLine("Min value in float List is {0}", myGenericFloat.Min());
            Console.WriteLine();

            // Class Matrix examples 
            Type type = typeof(Matrix<>);
            object[] matrixVersion = type.GetCustomAttributes(false);
            //VersionAttribute attr = (VersionAttribute)matrixVersion[1];
            //Console.WriteLine("Examples - usage of class Matrix, Version: {0}", attr.VersionInfo);
            Matrix<int> myFirstMatrix = new Matrix<int>(3, 4);
            for (int i = 0; i < myFirstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myFirstMatrix.GetLength(1); j++)
                {
                    myFirstMatrix[i, j] = (i + j) * (i + j);
                }
            }
            Matrix<int> mySecondMatrix = new Matrix<int>(3, 4);
            for (int i = 0; i < mySecondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < mySecondMatrix.GetLength(1); j++)
                {
                    mySecondMatrix[i, j] = (i * j) + (i * j);
                }
            }
            // Class Matrix + operator example
            Matrix<int> resultMatrix = myFirstMatrix + mySecondMatrix;
            Console.WriteLine("FirstMatrix:");
            Console.WriteLine(myFirstMatrix);
            Console.WriteLine("SecondMatrix:");
            Console.WriteLine(mySecondMatrix);
            Console.WriteLine("ResultMatrix:");
            Console.WriteLine(resultMatrix);


            // Class Matrix * operator example
            Matrix<int> myThirdMatrix = new Matrix<int>(4, 3);
            for (int i = 0; i < myThirdMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myThirdMatrix.GetLength(1); j++)
                {
                    myThirdMatrix[i, j] = (i * j) + (i * j);
                }
            }
            Console.WriteLine("ThirdMatrix:");
            Console.WriteLine(myThirdMatrix);

            Matrix<int> resultMulMatrix = myFirstMatrix * myThirdMatrix;
            Console.WriteLine("resultMulMatrix:");
            Console.WriteLine(resultMulMatrix);
        }
    }
}
