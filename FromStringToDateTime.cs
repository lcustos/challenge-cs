using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            var CultureInfo = new CultureInfo("FR-fr");
            return DateTime.Parse(dateStr, CultureInfo);
        }
    }
}