namespace PointGenerator.Classes
{
    using System;
    using System.IO;
    public static class PathStorage
    {
        /// <summary>
        /// Implementing method for writing points from list to file
        /// Catching all possible exeptions
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="points"></param>
        
        public static void WritePathToFile(string fileName, Path points)
        {
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                try
                {
                    for (int i = 0; i < points.Count; i++)
                    {
                        writer.WriteLine(String.Format("{0} {1} {2}", points[i].X, points[i].Y, points[i].Z));
                    }
                }
                catch (FileLoadException)
                {
                    throw new FileLoadException("Cannot load file!");
                }
                catch (FileNotFoundException)
                {
                    throw new FileNotFoundException("Cannot find file!");
                }
            }
        }

        /// <summary>
        /// Implement method for reading paths from file
        /// Catching all possible exceptions
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="points"></param>
        
        public static void ReadPathFromFile(string fileName, Path points)
        {
            StreamReader reader = new StreamReader(fileName);
            string output = string.Empty;
            using (reader)
            {
                try
                {
                    output = reader.ReadLine();
                    while (output != null)
                    {
                        string[] coords = output.Split(' ');
                        Point3D currentPoint = new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
                        points.Add(currentPoint);
                        output = reader.ReadLine();
                    }
                }
                catch (FileLoadException)
                {
                    throw new FileLoadException("Access to file denied!");
                }
                catch (FileNotFoundException)
                {
                    throw new FileNotFoundException("Cannot find file!");
                }
                catch (FormatException)
                {
                    throw new FormatException("Bad data format!");
                }
            }
        }
    }
}
