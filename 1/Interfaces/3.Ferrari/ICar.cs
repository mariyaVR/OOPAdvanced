using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ferrari
{
    interface ICar
    {
        string Model { get; }

        string Driver { get; }

        string UseBrakes();

        string GasPedal();
    }
}
