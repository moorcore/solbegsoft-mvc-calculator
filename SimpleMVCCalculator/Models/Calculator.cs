﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCCalculator.Models
{
    public class Calculator
    {
        public double value1 { get; set; }
        public double value2 { get; set; }
        public double result { get; set; }
        public string calculate { get; set; }
        public string notification { get; set; }
    }
}
