using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private static int index;

        public ListyIterator()
        {
            this.collection = new List<T>();
            index = 0;
        }

        public void Create(List<T> elementsList)
        {
            this.collection = new List<T>();
            this.collection.AddRange(elementsList);
            index = 0;
        }

        public bool Move()
        {
            if (index < collection.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < collection.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            try
            {
                Console.WriteLine(this.collection[index]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public string PrintAll()
        {

            return string.Join(" ", this.collection);
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }
    }
}