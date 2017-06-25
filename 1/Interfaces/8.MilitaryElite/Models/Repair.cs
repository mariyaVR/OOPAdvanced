using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Models
{
    using Interfaces;
    public class Repair : IRepair

    {
        public Repair(string partName, int hoursWorks)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorks;
        }
        public string PartName { get; }
        public int HoursWorked { get; }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
