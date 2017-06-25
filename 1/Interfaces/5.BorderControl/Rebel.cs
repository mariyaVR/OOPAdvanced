using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BorderControl
{
    class Rebel : IName, IAge, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public int Age { get; }

        public string Name { get; }

        public string Group { get; }

        public int Food { get; protected set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
