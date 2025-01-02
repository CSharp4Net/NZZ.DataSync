using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.DataSync.Logic.Statics
{
    public static class Convert
    {
        public static string ToString(object value, string nullValue = null)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is string)
                    return (string)value;
                else
                    return value.ToString();
            }
            else
                return nullValue;
        }

        public static int ToInt(object value, int nullValue = 0)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is int)
                    return (int)value;
                else
                {
                    int parsedValue = 0;

                    if (int.TryParse(value.ToString(), out parsedValue))
                        return parsedValue;
                    else
                        return nullValue;
                }
            }
            else
                return nullValue;
        }

        public static decimal ToDecimal(object value, decimal nullValue = 0)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is decimal)
                    return (decimal)value;
                else
                {
                    decimal parsedValue = 0;

                    if (decimal.TryParse(value.ToString(), out parsedValue))
                        return parsedValue;
                    else
                        return nullValue;
                }
            }
            else
                return nullValue;
        }

        public static double ToDouble(object value, double nullValue = 0)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is double)
                    return (double)value;
                else
                {
                    double parsedValue = 0;

                    if (double.TryParse(value.ToString(), out parsedValue))
                        return parsedValue;
                    else
                        return nullValue;
                }
            }
            else
                return nullValue;
        }

        public static bool ToBoolean(object value, bool nullValue = false)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is bool)
                    return (bool)value;
                else
                {
                    bool parsedValue = false;

                    if (bool.TryParse(value.ToString(), out parsedValue))
                        return parsedValue;
                    else
                        return nullValue;
                }
            }
            else
                return nullValue;
        }

        public static DateTime ToDateTime(object value)
        {
            return ToDateTime(value, DateTime.MinValue);
        }
        public static DateTime ToDateTime(object value, DateTime nullValue)
        {
            if (value != null && value != DBNull.Value)
            {
                if (value is DateTime)
                    return (DateTime)value;
                else
                {
                    DateTime parsedValue = DateTime.MinValue;

                    if (DateTime.TryParse(value.ToString(), out parsedValue))
                        return parsedValue;
                    else
                        return nullValue;
                }
            }
            else
                return nullValue;
        }
    }
}