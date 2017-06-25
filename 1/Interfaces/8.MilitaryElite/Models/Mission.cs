using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Models
{
    using Interfaces;
    public class Mission : IMission
    {
        private string state;
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; }

        public string State
        {
            get { return this.state; }
            set
            {
                if (value != "inProgress" & value != "Finished")
                {
                    throw new ArgumentException("State of mission is not correct!");
                }

                this.state = value;
            }
        }
        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
