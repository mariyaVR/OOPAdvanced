using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Models
{
    using Interfaces;
    class Commando : SpecialisedSolder, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corp) : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; }

        public void AddMisions(IMission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("Missions:");
            if (this.Missions.Count > 0)
            {
                sb.AppendLine()
                    .Append(string.Join("\n", this.Missions));
            }
            return sb.ToString();
        }
    }
}
