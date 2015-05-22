using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGenerator.Classes
{
    [Version ("2.11")]
    public class Matrix<T> where T : struct
    {
        private T [,] internalArray;

        public Matrix(int firstSize, int secondSize)
        {
            internalArray = new T[firstSize, secondSize];
        }

        /// <summary>
        /// Implemented public property to index elements in matrix
        /// </summary>
        /// <param name="firstSize"></param>
        /// <param name="secondSize"></param>
        /// <returns></returns>

        public T this[int firstSize, int secondSize]
        {
            get
            {
                if ((firstSize >= 0 && firstSize < this.internalArray.GetLength(0)) || (secondSize >= 0 && secondSize < this.internalArray.GetLength(1)))
                {
                    return this.internalArray[firstSize, secondSize];
                }
                else
                {
                    throw new IndexOutOfRangeException("No such element with this index!");
                }
            }
            set
            {
                if ((firstSize >= 0 && firstSize < this.internalArray.GetLength(0)) || (secondSize >= 0 && secondSize < this.internalArray.GetLength(1)))
                {
                    this.internalArray[firstSize, secondSize] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("No such element with this index!");
                }
            }
        }

        /// <summary>
        /// Implemented method to return matrix length
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>

        public int GetLength(int index)
        {
            if (index <= 0)
            {
                return this.internalArray.GetLength(0);
            }
            else
            {
                return this.internalArray.GetLength(1);
            }
        }

        /// <summary>
        /// Implemented method for the sum of two matrixes
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns></returns>

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetLength(0) == secondMatrix.GetLength(0)) || (firstMatrix.GetLength(1) == secondMatrix.GetLength(1)))
            {
                Matrix<T> returnMatrix = new Matrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));
                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < firstMatrix.GetLength(1); j++)
                    {
                        double currentResult = (double)Convert.ChangeType(firstMatrix[i, j], typeof(double)) + (double)Convert.ChangeType(secondMatrix[i, j], typeof(double));
                        returnMatrix[i, j] = (T)Convert.ChangeType(currentResult, typeof(T));
                    }
                }

                return (Matrix<T>)Convert.ChangeType(returnMatrix, typeof(Matrix<T>));
            }
            else
            {
                throw new ArgumentException("Matrixes must be of the same size");
            }
        }

        /// <summary>
        /// Implemented method for the product of two matrixes
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns></returns>

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.GetLength(1) == secondMatrix.GetLength(0)))
            {
                Matrix<T> returnMatrix = new Matrix<T>(firstMatrix.GetLength(0), firstMatrix.GetLength(1));
                for (int i = 0; i < firstMatrix.GetLength(0); i++)
                {
                    
                    for (int j = 0; j < firstMatrix.GetLength(1); j++)
                    {
                        double currentResult = 0;
                        for (int k = 0; k < firstMatrix.GetLength(1); k++)
                        {
                            double firstElement = (double)Convert.ChangeType(firstMatrix[i, k], typeof(double));
                            double secondElement = (double)Convert.ChangeType(firstMatrix[i, k], typeof(double));
                            currentResult += firstElement * secondElement;
                        }
                        returnMatrix[i, j] = (T)Convert.ChangeType(currentResult, typeof(T));
                    }
                }

                return (Matrix<T>)Convert.ChangeType(returnMatrix, typeof(Matrix<T>));
            }
            else
            {
                throw new ArgumentException("Column count of the first Matrix must be equal to row count of the second matrix");
            }
        }

        /// <summary>
        /// Implemented method ToString() to return the matrix
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < this.internalArray.GetLength(0); i++)
                {
                    for (int j = 0; j < this.internalArray.GetLength(1); j++)
                    {
                        string curString = (string)Convert.ChangeType(this.internalArray[i, j], typeof(string));
                        builder.Append(curString.PadRight(5, ' '));
                    }
                    builder.Append("\n");
                }
                return builder.ToString();
            }
            catch (Exception)
            {
                return "Cannot use ToString() for this matrix!";
            }
        }
    }
}
