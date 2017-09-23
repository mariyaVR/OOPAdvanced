using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public class PersonComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int result = 0;
                if (x.Name.CompareTo(y.Name) != 0)
                {
                    return x.Name.CompareTo(y.Name);
                }
                if (x.Age.CompareTo(y.Age) != 0)
                {
                    return x.Age.CompareTo(y.Age);
                }
                return result;
            }
        }

        public int CompareTo(Person other)
        {
            int result = 0;
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return result;
        }

        public override int GetHashCode()
        {
            int lettersSum = 0;
            for (int i = 0; i < this.Name.Length; i++)
            {
                lettersSum += this.Name[i];
            }
            return lettersSum * this.Age;
        }

        public override bool Equals(object obj)
        {
            var newObject = obj as Person;

            return this.GetHashCode() == newObject.GetHashCode();
        }
    }
}