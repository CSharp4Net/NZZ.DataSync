using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Extensions
{
    public static class ObjectX
    {
        public static string ToStr(this object obj, string nullValue = null)
        {
            return Statics.Convert.ToString(obj, nullValue);
        }

        public static int ToInt(this object obj, int nullValue = 0)
        {
            return Statics.Convert.ToInt(obj, nullValue);
        }

        public static double ToDouble(this object obj, double nullValue = 0)
        {
            return Statics.Convert.ToDouble(obj, nullValue);
        }

        public static decimal ToDecimal(this object obj, decimal nullValue = 0)
        {
            return Statics.Convert.ToDecimal(obj, nullValue);
        }

        public static bool ToBoolean(this object obj, bool nullValue = false)
        {
            return Statics.Convert.ToBoolean(obj, nullValue);
        }

        public static DateTime ToDateTime(this object obj)
        {
            return ToDateTime(obj, DateTime.MinValue);
        }
        public static DateTime ToDateTime(this object obj, DateTime nullValue)
        {
            return Statics.Convert.ToDateTime(obj, nullValue);
        }
    }
}