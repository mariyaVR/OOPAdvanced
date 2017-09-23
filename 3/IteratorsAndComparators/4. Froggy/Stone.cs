using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Froggy
{
    public class Stone
    {
        private int number;

        public Stone(int number)
        {
            this.Number = number;
        }

        public int Number { get; } //???!!!!

        public override string ToString()
        {
            return this.Number.ToString();
        }
    }
}