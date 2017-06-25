using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Models
{
    using Interfaces;
    public class SpecialisedSolder : Private, ISpecialisedSoldier
    {
        private string corp;

        public SpecialisedSolder(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public string Corp
        {
            get { return this.corp; }
            set
            {
                if (value != "Airforces" & value != "Marines")
                {
                    throw new InvalidOperationException();
                }

                this.corp = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Corps: " + this.Corp;
        }
    }
}
