namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        //field
        private const int initialCapacity = 4;
        private T[] elements;
        private int index;

        //constructor
        public GenericList()
        {
            this.elements = new T[initialCapacity];
            this.index = 0;
        }

        public T this[int index]
        {
            get { return this.elements[index]; }
            set { this.elements[index] = value; }
        }

        //methods
        public void Add(T element)
        {
            if (this.index == this.elements.Length)
            {
                AutoGrow();
            }
            this.elements[this.index] = element;
            this.index++;
        }

        private void AutoGrow()
        {
            T[] newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        public int Count()
        {
            return this.index + 1;
        }

        public void Insert(int index, T element)
        {
            if (this.index >= elements.Length )
            {
                AutoGrow();
            }
            if (index < this.elements.Length)
            {
                T[] newElements = new T[this.elements.Length];

                for (int i = 0; i < index; i++)
                {
                    newElements[i] = elements[i];
                }
                newElements[index] = element;

                for (int i = index + 1; i < newElements.Length; i++)
                {
                    newElements[i] = elements[i - 1];
                }
                elements = newElements;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of the list");
            }    
        }

        public void Delete(int index)
        {
            if (index < this.elements.Length)
            {
                T[] newElement = new T[this.elements.Length];
                for (int i = 0; i < index; i++)
                {
                    newElement[i] = elements[i];
                }

                for (int i = index + 1; i < newElement.Length; i++)
                {
                    newElement[i-1] = elements[i];
                }

                elements = newElement;
            }
        
        }

        public int FindElemByValue(T value)
        {
            int indexFound = -1;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }

        public void Clear()
        {
            elements = new T[initialCapacity];
        }

        public override string ToString()
        {
            StringBuilder endText = new StringBuilder();
            foreach (var item in this.elements)
            {
                endText.AppendFormat("{0} ", item);
            }

            return endText.ToString().Trim();
        }

        public T Max()
        {
            dynamic maxElem = int.MinValue;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] > maxElem)
                {
                    maxElem = this.elements[i];
                }
            }

            return maxElem;
        }

        public T Min()
        {
            dynamic minElem = int.MaxValue;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] < minElem)
                {
                    minElem = this.elements[i];
                }
            }

            return minElem;
        }
    }
}
