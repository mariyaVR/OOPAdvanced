using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BorderControl
{
    class Citizen : IIdentifiable, IBirthDate, IName, IBuyer
    {
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.BirthDate = birthDate;
            this.Food = 0;
        }

        public string BirthDate { get; }
        public string Name { get; }
        public int Age { get; }
        public string ID {get; }
        public int Food
        {
            get; protected set;
        }

        public void BuyFood()
        {
        this.Food += 10;
        }
    }
}
