using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        private const int initialCapacity = 16;

        private T[] elements;
        private int count;

        public CustomList()
        {
            this.elements = new T[initialCapacity];
            this.Count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                count = value;
            }
        }

        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                Resize();
            }

            this.elements[this.count] = element;
            Count++;
        }

        private void DecreaseElementsCount(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.elements[index] = this.elements[i + 1];
            }

            this.elements[Count - 1] = default(T);
            this.Count--;
        }

        public T Remove(int index)
        {
            this.ValidateOperation();
            T element = this.elements[index];
            this.DecreaseElementsCount(index);
            return element;
        }

        private void Resize()
        {
            int currentLength = this.elements.Length;
            T[] newElements = new T[currentLength * 2];
            Array.Copy(this.elements, newElements, currentLength);
            this.elements = newElements;
        }

        private void ValidateIndex(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index is outside the bounds of the collection");
            }
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.elements[index];
            }     
        }

        public bool Contains(T element)
        {
            this.ValidateOperation();
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int indexSource, int indexDestination)
        {
            this.ValidateOperation();
            ValidateIndex(indexSource);
            ValidateIndex(indexDestination);
            T temp = this.elements[indexSource];
            this.elements[indexSource] = this.elements[indexDestination];
            this.elements[indexDestination] = temp;
        }

        public int CountOfElementsGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (elements[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        private void ValidateOperation()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot perform operation on empty sequence");
            }
        }
        public T Max()
        {
            this.ValidateOperation();
            T maxItem = this.elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(maxItem) > 0)
                {
                    maxItem = this.elements[i];
                }
            }

            return maxItem;
        }

        public T Min()
        {
            this.ValidateOperation();
            T minItem = this.elements[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(minItem) < 0)
                {
                    minItem = this.elements[i];
                }
            }

            return minItem;
        }

        public void Print()
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
