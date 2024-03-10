using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    internal class TimeConverter : ITimeConvert
    {
        public double ConvertHours(double days)
        {
            return days * 24;
        }

        public double ConvertMinutes(double days)
        {
           return ConvertHours(days) * 60; 
        }

        public double ConvertSeconds(double days)
        {
            return ConvertMinutes(days) * 60; 
        }

    }
}
