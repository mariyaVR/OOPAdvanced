﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DivisionStrategy : IStrategy
{
    public int Calculate(int firstOperand, int secondOperand)
    {
        return firstOperand / secondOperand;
    }
}

