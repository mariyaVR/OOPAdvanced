﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Interfaces
{
    public interface IPrivate: ISoldier
    {
        double Salary { get; }
    }
}