using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CustomList
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> ourList) where T : IComparable<T>
        {
            bool isSorted = false;
            while (!isSorted)
            {
                bool elementFound = false;
                for (int i = 0; i < ourList.Count - 1; i++)
                {
                    if (ourList[i].CompareTo(ourList[i + 1]) > 0)
                    {
                        ourList.Swap(i, i + 1);
                        elementFound = true;
                        break;
                    }
                }

                if (elementFound == false)
                {
                    isSorted = true;
                }
            }

            return ourList;
        }
    }
}