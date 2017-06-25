using System;

namespace _1.DefineInterfaceIPerson
{
    internal class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public Citizen(string name, int age, string ID, string BirthDate)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public string ID { get; }

        public string Birthdate { get; }
    }
}