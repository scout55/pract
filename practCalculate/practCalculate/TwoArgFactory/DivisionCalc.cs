﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
  public  class DivisionCalc : ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            double result;
            result = firstArg / secondArg;
            return result;
        }
    }
}