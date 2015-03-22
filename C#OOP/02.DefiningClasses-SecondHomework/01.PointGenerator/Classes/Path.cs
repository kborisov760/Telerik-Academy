namespace PointGenerator.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Path
    {
        private List<Point3D> pointsList;

        public Path()
        {
            this.pointsList = new List<Point3D>();
        }

        public Path(Point3D inputPoint) : this()
        {
            pointsList.Add(inputPoint);
        }
        
        /// <summary>
        /// Implemented a property for counting elements in point list
        /// </summary>
        
        public int Count
        {
            get
            {
                return this.pointsList.Count;
            }
        }

        /// <summary>
        /// Implemented a method for adding elements to the point list
        /// </summary>
        /// <param name="inputPoint"></param>
        
        public void Add(Point3D inputPoint)
        {
            pointsList.Add(inputPoint);
        }

        /// <summary>
        /// Implemented method for removing element at special position
        /// </summary>
        /// <param name="index"></param>
        
        public void RemoveAt(int index)
        {
            try
            {
                pointsList.RemoveAt(index);
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException("No such elements on this index!");
            }
            
        }

        /// <summary>
        /// Implemented property used for indexer of the elements in the list
        /// </summary>
        /// <param name="index"></param>
        
        public Point3D this[int index]
        {
            get
            {
                if (index >= 0 && index < this.pointsList.Count)
                {
                    return this.pointsList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("List does not contain element with this index!");
                }
            }

            set
            {
                if (index >= 0 && index < this.pointsList.Count)
                {
                    this.pointsList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("List does not contain element with this index!");
                }
            }
        }
    }
}
