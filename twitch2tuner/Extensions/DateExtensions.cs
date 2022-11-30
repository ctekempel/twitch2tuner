using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace twitch2tuner.Extensions
{
    internal static class DateExtensions
    {
        public static string ToDateString(this DateTime dateTime)
        {
            //return dateTime.ToString("yyyyMMddHHmmss zzz");
            return dateTime.ToString("yyyyMMddHHmmss zz");
        }

    }
}
