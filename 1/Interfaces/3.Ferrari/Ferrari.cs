using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ferrari
{
    class Ferrari : ICar
    {
        public Ferrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }
        public string Driver
        {
            get;
        }

        public string Model
        {
            get;
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
    }
}
