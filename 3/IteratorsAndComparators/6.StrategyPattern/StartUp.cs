using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> nameSort = new SortedSet<Person>(new Person.NameLenghtComperator());
            SortedSet<Person> ageSort = new SortedSet<Person>(new Person.AgeComperatot());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                nameSort.Add(person);
                ageSort.Add(person);
            }
            foreach (var person in nameSort)
            {
                Console.WriteLine(person);
            }
            foreach (var person in ageSort)
            {
                Console.WriteLine(person);
            }
        }
    }
}