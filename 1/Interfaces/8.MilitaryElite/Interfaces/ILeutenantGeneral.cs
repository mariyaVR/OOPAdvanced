﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral
    {
        List<IPrivate> Privates { get; }
    }
}
