//------------------------------------------------------------------------------ 
// 
// File provided for Reference Use Only by ioCode (c) 2022.
// Copyright (c) ioCode. All rights reserved.
//
// Author: Gokhan Erdogdu
// 
//------------------------------------------------------------------------------
using System;

namespace ioCode.Common
{
    public static class MathExtensions
    {
        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <typeparam name="T">A generic type derived from the 'System.IComparable' interface.</typeparam>
        /// <param name="value">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        private static T SetRange<T>(T value, T first, T last)
            where T : IComparable
        {
            T min = (((IComparable)first).CompareTo(last) < 0) ? first : last;
            T max = (((IComparable)first).CompareTo(last) > 0) ? first : last;
            return (((IComparable)value).CompareTo(min) < 0)
                ? min
                : (((IComparable)value).CompareTo(max) > 0)
                ? max
                : value;
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static byte Range(this byte n, byte first, byte last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static decimal Range(this decimal n, decimal first, decimal last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static double Range(this double n, double first, double last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static float Range(this float n, float first, float last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static int Range(this int n, int first, int last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static long Range(this long n, long first, long last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static sbyte Range(this sbyte n, sbyte first, sbyte last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static short Range(this short n, short first, short last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static uint Range(this uint n, uint first, uint last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static ulong Range(this ulong n, ulong first, ulong last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static ushort Range(this ushort n, ushort first, ushort last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static TimeSpan Range(this TimeSpan n, TimeSpan first, TimeSpan last)
        {
            return SetRange(n, first, last);
        }

        /// <summary>
        /// Forces the specified value between two limits.
        /// </summary>
        /// <param name="n">Base value.</param>
        /// <param name="first">The first value to compare.</param>
        /// <param name="last">The last value to compare.</param>
        /// <returns>Returns a value between 'first' and 'last'.</returns>
        public static DateTime Range(this DateTime n, DateTime first, DateTime last)
        {
            return SetRange(n, first, last);
        }
    }
}
