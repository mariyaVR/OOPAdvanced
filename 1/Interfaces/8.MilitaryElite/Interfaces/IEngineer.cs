﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Interfaces
{
    interface IEngineer
    {
        List<IRepair> Repairs { get; }
    }
}