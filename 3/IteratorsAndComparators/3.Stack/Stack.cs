using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] collection;

        public Stack()
        {
            this.collection = new T[0];
        }

        public void Push(T element)
        {
            T[] tempCollection = new T[collection.Length + 1];
            collection.CopyTo(tempCollection, 0);
            tempCollection[collection.Length] = element;
            this.collection = tempCollection;
        }

        public void Pop()
        {
            if (collection.Length == 0)
            {
                Console.WriteLine("No elements");
                return; //
            }

            T[] tempCollection = new T[collection.Length - 1];

            for (int i = 0; i < tempCollection.Length; i++)
            {
                tempCollection[i] = this.collection[i];
            }

            this.collection = tempCollection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}