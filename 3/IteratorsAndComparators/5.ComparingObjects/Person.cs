using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ComparingObjects
{
    public class Person: IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }

            set
            {
                town = value;
            }
        }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            int comparison = 0;
            if (this.Name.CompareTo(other.Name) != 0)
            {
                comparison = this.Name.CompareTo(other.Name);
            }
            if (this.Age.CompareTo(other.Age) != 0)
            {
                comparison = this.Age.CompareTo(other.Age);
            }
            if (this.Town.CompareTo(other.Town) != 0)
            {
                comparison = this.Town.CompareTo(other.Town);
            }
            return comparison;
        }
    }
}
