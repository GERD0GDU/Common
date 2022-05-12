//------------------------------------------------------------------------------ 
// 
// File provided for Reference Use Only by ioCode (c) 2022.
// Copyright (c) ioCode. All rights reserved.
//
// Author: Gokhan Erdogdu
//
// Description: All extended methods used for conversion operations do not
//              offer any guarantees.
//              None of the extended methods throw exceptions.
//              The extended method returns '0' (zero) if the conversion fails.
//              When the conversion is successful, it returns a value in the
//              minimum and maximum range of the converted type.
// 
//------------------------------------------------------------------------------
using System;
using System.Globalization;

namespace ioCode.Common
{
    public static class ConversionExtensions
    {
        private const double MinDecValue = -7.9228162514264338E+28d;
        private const double MaxDecValue =  7.9228162514264338E+28d;

        /// <summary>
        /// Converts the string representation of a number to its System.Decimal equivalent using the specified culture-specific format information.
        /// </summary>
        /// <param name="s">The string representation of the number to convert.</param>
        /// <param name="provider">An System.IFormatProvider that supplies culture-specific parsing information about s.</param>
        /// <returns>The System.Decimal number equivalent to the number contained in s as specified by provider.</returns>
        public static decimal ToDecimal(this string s, IFormatProvider provider)
        {
            if (s.IsNull()) {
                return 0m;
            }

            if ((s.IndexOf("0x", StringComparison.InvariantCultureIgnoreCase) == 0)
                || (s.IndexOf("&H", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                s = s.Substring(2).Right(16);
                return ulong.TryParse(s, NumberStyles.HexNumber, provider, out ulong ulResult)
                    ? (decimal)ulResult
                    : 0m;
            }

            if (decimal.TryParse(s, NumberStyles.Number, provider, out decimal decResult)) {
                return decResult;
            }

            if (double.TryParse(s, NumberStyles.Float, provider, out double dblResult))
            {
                return (dblResult >= MaxDecValue)
                    ? decimal.MaxValue
                    : (dblResult <= MinDecValue)
                        ? decimal.MinValue
                        : new decimal(dblResult);
            }

            return 0m;
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Decimal equivalent.
        /// </summary>
        /// <param name="s">The string representation of the number to convert.</param>
        /// <returns>The equivalent to the number contained in s.</returns>
        public static decimal ToDecimal(this string s)
        {
            return s.ToDecimal(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in s.</returns>
        public static double ToDouble(this string s, IFormatProvider provider)
        {
            if (s.IsNull()) {
                return 0d;
            }

            if ((s.IndexOf("0x", StringComparison.InvariantCultureIgnoreCase) == 0)
                || (s.IndexOf("&H", StringComparison.InvariantCultureIgnoreCase) == 0))
            {
                s = s.Substring(2).Right(16);
                return ulong.TryParse(s, NumberStyles.HexNumber, provider, out ulong ulResult)
                    ? (double)ulResult
                    : 0d;
            }

            return double.TryParse(s ?? "0", NumberStyles.Float, provider, out double result)
                ? result
                : 0d;
        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <returns>A double-precision floating-point number that is equivalent to the numeric value or symbol specified in s.</returns>
        public static double ToDouble(this string s)
        {
            return (double)s.ToDouble(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in s.</returns>
        public static float ToSingle(this string s, IFormatProvider provider)
        {
            return (float)s.ToDouble(provider).Range(float.MinValue, float.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <returns>A single-precision floating-point number equivalent to the numeric value or symbol specified in s.</returns>
        public static float ToSingle(this string s)
        {
            return (float)s.ToSingle(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 8-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents a number to convert. The string is interpreted using the System.Globalization.NumberStyles.Integer style.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s. If provider is null, the thread current culture is used.</param>
        /// <returns>An 8-bit signed integer that is equivalent to the number specified in s.</returns>
        public static sbyte ToSByte(this string s, IFormatProvider provider)
        {
            return (sbyte)s.ToDecimal(provider).Range(sbyte.MinValue, sbyte.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 8-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents a number to convert.</param>
        /// <returns>An 8-bit signed integer that is equivalent to the number contained in the s parameter.</returns>
        public static sbyte ToSByte(this string s)
        {
            return (sbyte)s.ToDecimal().Range(sbyte.MinValue, sbyte.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="provider">An System.IFormatProvider that supplies culture-specific formatting information about s.</param>
        /// <returns>A 16-bit signed integer equivalent to the number specified in s.</returns>
        public static short ToInt16(this string s, IFormatProvider provider)
        {
            return (short)s.ToDecimal(provider).Range(short.MinValue, short.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to the number contained in s.</returns>
        public static short ToInt16(this string s)
        {
            return (short)s.ToDecimal().Range(short.MinValue, short.MaxValue);
        }


        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A 32-bit signed integer equivalent to the number specified in s.</returns>
        public static int ToInt32(this string s, IFormatProvider provider)
        {
            return (int)s.ToDecimal(provider).Range(int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the number contained in s.</returns>
        public static int ToInt32(this string s)
        {
            return (int)s.ToDecimal().Range(int.MinValue, int.MaxValue);
        }


        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A 64-bit signed integer equivalent to the number specified in s.</returns>
        public static long ToInt64(this string s, IFormatProvider provider)
        {
            return (long)s.ToDecimal(provider).Range(long.MinValue, long.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="s">A string containing a number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the number contained in s.</returns>
        public static long ToInt64(this string s)
        {
            return (long)s.ToDecimal().Range(long.MinValue, long.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its System.Byte equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert. The string is interpreted using the System.Globalization.NumberStyles.Integer style.</param>
        /// <param name="provider">An object that supplies culture-specific parsing information about s. If provider is null, the thread current culture is used.</param>
        /// <returns>A byte value that is equivalent to the number contained in s.</returns>
        public static byte ToByte(this string s, IFormatProvider provider)
        {
            return (byte)s.ToDecimal(provider).Range(byte.MinValue, byte.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Byte equivalent.
        /// </summary>
        /// <param name="s">A string that contains a number to convert.</param>
        /// <returns>A byte value that is equivalent to the number contained in s.</returns>
        public static byte ToByte(this string s)
        {
            return (byte)s.ToDecimal().Range(byte.MinValue, byte.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents the number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the number specified in s.</returns>
        public static ushort ToUInt16(this string s, IFormatProvider provider)
        {
            return (ushort)s.ToDecimal(provider).Range(ushort.MinValue, ushort.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents the number to convert.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the number contained in s.</returns>
        public static ushort ToUInt16(this string s)
        {
            return (ushort)s.ToDecimal().Range(ushort.MinValue, ushort.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 32-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents the number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the number specified in s.</returns>
        public static uint ToUInt32(this string s, IFormatProvider provider)
        {
            return (uint)s.ToDecimal(provider).Range(uint.MinValue, uint.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string representing the number to convert.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the number contained in s.</returns>
        public static uint ToUInt32(this string s)
        {
            return (uint)s.ToDecimal().Range(uint.MinValue, uint.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified culture-specific format to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents the number to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <returns>A 64-bit unsigned integer equivalent to the number specified in s.</returns>
        public static ulong ToUInt64(this string s, IFormatProvider provider)
        {
            return (ulong)s.ToDecimal(provider).Range(ulong.MinValue, ulong.MaxValue);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="s">A string that represents the number to convert.</param>
        /// <returns>A 64-bit unsigned integer equivalent to the number contained in s.</returns>
        public static ulong ToUInt64(this string s)
        {
            return (ulong)s.ToDecimal().Range(ulong.MinValue, ulong.MaxValue);
        }

        #region Convert to HexString Methods

        /// <summary>
        /// Converts an 8-bit unsigned integer to a hexadecimal string.<br/>
        /// format:<br/>
        /// "0" --> "0x##"<br/>
        /// "H" --> "&H##"
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <param name="format">A value in the format "0" or "H" can be specified.</param>
        /// <returns>Returns a hexadecimal string value based on the format value.</returns>
        public static string ToHexString(this byte n, string format)
        {
            switch (format ?? "")
            {
                case "0":
                case "0x":
                case "0X":
                    return string.Format("0x{0:X2}", n);
                case "h":
                case "H":
                case "&h":
                case "&H":
                    return string.Format("&H{0:X2}", n);
                default:
                    return string.Format("{0:X}", n);
            }
        }

        /// <summary>
        /// Converts an 8-bit unsigned integer to a hexadecimal string.
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <returns>Returns a hexadecimal string value in the default format.</returns>
        public static string ToHexString(this byte n)
        {
            return ToHexString(n, null);
        }

        /// <summary>
        /// Converts an 16-bit unsigned integer to a hexadecimal string.<br/>
        /// format:<br/>
        /// "0" --> "0x####"<br/>
        /// "H" --> "&H####"
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <param name="format">A value in the format "0" or "H" can be specified.</param>
        /// <returns>Returns a hexadecimal string value based on the format value.</returns>
        public static string ToHexString(this ushort n, string format)
        {
            switch (format ?? "")
            {
                case "0":
                case "0x":
                case "0X":
                    return string.Format("0x{0:X4}", n);
                case "h":
                case "H":
                case "&h":
                case "&H":
                    return string.Format("&H{0:X4}", n);
                default:
                    return string.Format("{0:X}", n);
            }
        }

        /// <summary>
        /// Converts an 16-bit unsigned integer to a hexadecimal string.
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <returns>Returns a hexadecimal string value in the default format.</returns>
        public static string ToHexString(this ushort n)
        {
            return ToHexString(n, null);
        }

        /// <summary>
        /// Converts an 32-bit unsigned integer to a hexadecimal string.<br/>
        /// format:<br/>
        /// "0" --> "0x########"<br/>
        /// "H" --> "&H########"
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <param name="format">A value in the format "0" or "H" can be specified.</param>
        /// <returns>Returns a hexadecimal string value based on the format value.</returns>
        public static string ToHexString(this uint n, string format)
        {
            switch (format ?? "")
            {
                case "0":
                case "0x":
                case "0X":
                    return string.Format("0x{0:X8}", n);
                case "h":
                case "H":
                case "&h":
                case "&H":
                    return string.Format("&H{0:X8}", n);
                default:
                    return string.Format("{0:X}", n);
            }
        }

        /// <summary>
        /// Converts an 32-bit unsigned integer to a hexadecimal string.
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <returns>Returns a hexadecimal string value in the default format.</returns>
        public static string ToHexString(this uint n)
        {
            return ToHexString(n, null);
        }

        /// <summary>
        /// Converts an 64-bit unsigned integer to a hexadecimal string.<br/>
        /// format:<br/>
        /// "0" --> "0x################"<br/>
        /// "H" --> "&H################"
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <param name="format">A value in the format "0" or "H" can be specified.</param>
        /// <returns>Returns a hexadecimal string value based on the format value.</returns>
        public static string ToHexString(this ulong n, string format)
        {
            switch (format ?? "")
            {
                case "0":
                case "0x":
                case "0X":
                    return string.Format("0x{0:X16}", n);
                case "h":
                case "H":
                case "&h":
                case "&H":
                    return string.Format("&H{0:X16}", n);
                default:
                    return string.Format("{0:X}", n);
            }
        }

        /// <summary>
        /// Converts an 64-bit unsigned integer to a hexadecimal string.
        /// </summary>
        /// <param name="n">A byte that represents the number to convert.</param>
        /// <returns>Returns a hexadecimal string value in the default format.</returns>
        public static string ToHexString(this ulong n)
        {
            return ToHexString(n, null);
        }

        #endregion // Convert to HexString Methods
    }
}
