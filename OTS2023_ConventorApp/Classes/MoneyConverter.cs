using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    internal class MoneyConverter
    {
        public double ConvertMoney(double value)
        {
            return value * 117.18;
        }

        public double ConvertArray(string array)
        {
            string[] values = array.Split(',');

            double number = 0;
            for (int i = 0; i < values.Length; i++)
            {
                number += Double.Parse(values[i]);
            }

            return ConvertMoney(number);
        }
    }
}
