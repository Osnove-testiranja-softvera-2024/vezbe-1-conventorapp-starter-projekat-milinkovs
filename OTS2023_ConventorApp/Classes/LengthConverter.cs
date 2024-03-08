﻿using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    public class LengthConverter : IConvert
    {
        public double Convert(double value)
        {
            return Math.Round(value / 3.281, 3);
        }
    }
}
