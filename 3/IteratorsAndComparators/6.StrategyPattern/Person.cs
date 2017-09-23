using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StrategyPattern
{
    public class Person
    {
        private string name;
        private int age;

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

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public class NameLenghtComperator : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                int comparison = 0;
                if (x.name.Length.CompareTo(y.name.Length)!=0)
                {
                    comparison = x.name.Length.CompareTo(y.name.Length);
                }
                else
                {
                    string fitstName = x.name.ToLower();
                    string secondName = y.name.ToLower();
                    comparison = fitstName[0].CompareTo(secondName[0]);
                }
                return comparison;
            }
        }       

        public class AgeComperatot: IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                  return x.age.CompareTo(y.age);                
            }
        }

        public override string ToString()
        {
            return $"{this.name} {this.age}";
        }
    }
}
