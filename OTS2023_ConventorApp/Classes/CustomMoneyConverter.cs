using OTS2023_ConventorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp.Classes
{
    internal class CustomMoneyConverter : ICustomMoneyConvert
    {
        public string ConvertCustomMoney(string value)
        {
            try
            {
                string[] split = Regex.Split(value, @"\s+"); // 50$,to,€
                string[] valuta = Regex.Split(split[0], @"\d+"); // $
                string[] broj = Regex.Split(split[0], @"\D+"); // 50

                string num = broj[0]; // broj(50)
                string curr1 = valuta[1]; // prva valuta
                string curr2 = split[2]; // druga valuta

                if (curr1 == "$" && curr2 == "€")
                {
                    return (Double.Parse(num) * 0.85).ToString();
                }

                else if (curr1 == "€" && curr2 == "$")
                {
                    return (Double.Parse(num) / 1.18).ToString();
                }

                else if (curr1 == "£" && curr2 == "€")
                {
                    return (Double.Parse(num) * 1.15).ToString();
                }

                else if (curr1 == "€" && curr2 == "£")
                {
                    return (Double.Parse(num) * 0.85).ToString();
                }
                else
                {
                    return "Bad input!";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
