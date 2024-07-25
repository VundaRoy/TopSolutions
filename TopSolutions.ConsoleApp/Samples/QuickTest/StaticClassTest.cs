using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.QuickTest
{
    public static class StaticClassTest
    {
        internal static string GetDateStringValue(object obj)
        {
            if (obj == null || obj.ToString().Contains("/9999"))
            {
                return String.Empty;
            }
            else
            {
                DateTime tempDate = new DateTime();
                if (DateTime.TryParse(obj.ToString(), out tempDate))
                {
                    return tempDate.ToString("dd/MM/yyyy");
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        internal static string GetStringValue(object obj)
        {
            if (obj == null)
            {
                return String.Empty;
            }
            else
            {
                return obj.ToString().Trim();
            }
        }
        internal static DateTime ConvertToDateTime0AM(DateTime? date)
        {
            DateTime tempDate = new DateTime();

            if (date.HasValue)
            {
                string tempDateString = date.Value.ToString("dd/MM/yyyy");

                DateTime.TryParse(tempDateString, out tempDate);
            }

            return tempDate;
        }
        internal static DateTime GetDateTimeValue(string value)
        {
            DateTime dateTime;

            if (!DateTime.TryParse(value, out dateTime))
            {
                dateTime = new DateTime();
            }

            return dateTime;
        }

        internal static DateTime GetDateTimeValueWithExact(string value, string exactFormat = "dd/MM/yyyy", bool allowHighDate = false)
        {
            DateTime dateTime;

            if (string.IsNullOrEmpty(value) && allowHighDate == true)
            {
                dateTime = new DateTime(9999, 12, 31);
            }
            else if (!DateTime.TryParseExact(value, exactFormat, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                dateTime = new DateTime();
            }

            return dateTime;
        }

    }
}
