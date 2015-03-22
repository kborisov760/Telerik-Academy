using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointGenerator.Classes
{
    public class GenericList<T> where T : struct
    {
        private const int INITIAL_SIZE = 8;
        private T[] internalArray;
        private int count = 0;

        public GenericList()
        {
            internalArray = new T[INITIAL_SIZE];
        }

        public GenericList(int inputSize)
        {
            internalArray = new T[inputSize];
        }

        public int Capacity
        {
            get { return this.internalArray.Count(); }
        }

        public int Count
        {
            get { return this.count; }
        }

        /// <summary>
        /// Implemented property about using indexes for elements in generic list
        /// Some exeptions handled and value assignments
        /// </summary>
        /// <param name="index"></param>
        
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.count)
                {
                    return this.internalArray[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }
            }
            set
            {
                if (index >= 0 && index < this.count)
                {
                    Type type = value.GetType();
                    if (type == typeof(T))
                    {
                        this.internalArray[index] = value;
                    }
                    else
                    {
                        throw new FormatException("Input type must be " + typeof(T).Name);
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }    
            }
        }

        /// <summary>
        /// Implemented method for resizing generic list
        /// </summary>
        
        public void Resize()
        {
            T[] newInternalArray = new T[this.Capacity * 2];
            for (int i = 0; i < this.count; i++)
            {
                newInternalArray[i] = internalArray[i];
            }
            
            this.internalArray = newInternalArray;
        }

        /// <summary>
        /// Implemened method to add elements to generic list
        /// </summary>
        /// <param name="inputElement"></param>
        
        public void Add(T inputElement)
        {
            if (this.count == this.Capacity)
            {
                this.Resize();
            }
            
            internalArray[this.count] = inputElement;
            count++;
        }

        /// <summary>
        /// Implemented method for removing element at specified index
        /// </summary>
        /// <param name="atIndex"></param>
        
        public void Remove(int atIndex)
        {
            if (atIndex >= this.count || atIndex < 0)
            {
                throw new IndexOutOfRangeException("Index was out of range!");
            }
            else if (atIndex == this.count - 1)
            {
                this.count--;
            }
            else
            {
                for (int i = atIndex; i < count - 1; i++)
                {
                    this.internalArray[i] = this.internalArray[i + 1];
                }

                this.count--;
            }
        }

        /// <summary>
        /// Implemented method for inserting element at specified index
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="atIndex"></param>
        
        public void Insert(T inputValue, int atIndex)
        {
            if (this.count == this.Capacity)
            {
                this.Resize();
            }

            for (int i = this.count; i > atIndex; i--)
            {
                this.internalArray[i] = this.internalArray[i - 1];
            }

            this.internalArray[atIndex] = inputValue;
            count++;
        }

        /// <summary>
        /// Implemented method for clearing element
        /// </summary>

        public void Clear()
        {
            this.count = 0;
        }

        /// <summary>
        /// Implemented method to return the index of searched element
        /// </summary>
        /// <param name="searchedElement"></param>
        /// <returns></returns>

        public int IndexOf(T searchedElement)
        {
            int index = -1;
            for (int i = 0; i < this.count; i++)
            {
                if (searchedElement.Equals(this.internalArray[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Implemented method to search for the smallest element
        /// </summary>
        /// <returns></returns>

        public T Min()
        {
            double minValue = Double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                double currentValueAsDouble = (double)Convert.ChangeType(this.internalArray[i], typeof(double));
                if (currentValueAsDouble < minValue)
                {
                    minValue = currentValueAsDouble;
                }
            }

            return (T)Convert.ChangeType(minValue, typeof(T));
        }

        /// <summary>
        /// Implemented method to search for the biggest element
        /// </summary>
        /// <returns></returns>

        public T Max()
        {
            double maxValue = Double.MinValue;
            for (int i = 0; i < count; i++)
            {
                double currentValueAsDouble = (double)Convert.ChangeType(this.internalArray[i], typeof(double));
                if (currentValueAsDouble > maxValue)
                {
                    maxValue = currentValueAsDouble;
                }
            }

            return (T)Convert.ChangeType(maxValue, typeof(T));
        }

        public override string ToString()
        {
            try
            {
                StringBuilder output = new StringBuilder(count);
                for (int i = 0; i < count; i++)
                {
                    output.Append(Convert.ChangeType(this.internalArray[i], typeof(string)) + "\n");
                }

                return output.ToString();
            }
            catch (Exception)
            {

                return "Cannot use ToString() for this list!";
            }
            
        }
    }
}
