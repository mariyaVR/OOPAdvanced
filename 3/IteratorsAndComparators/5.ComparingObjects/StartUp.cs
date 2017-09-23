﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] personInfo = input.Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];
                Person person = new Person(name, age, town);
                people.Add(person);
                input = Console.ReadLine();
            }
            int personIndex = int.Parse(Console.ReadLine()) - 1;
            Person desiredPerson = people[personIndex];
            int equalPeople = 0;
            foreach (var person in people)
            {
                if (person.CompareTo(desiredPerson) == 0)
                {
                    equalPeople++;
                }
            }
            if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}");
        }
    }
}