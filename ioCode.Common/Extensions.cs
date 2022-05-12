//------------------------------------------------------------------------------ 
// 
// File provided for Reference Use Only by ioCode (c) 2022.
// Copyright (c) ioCode. All rights reserved.
//
// Author: Gokhan Erdogdu
// 
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ioCode.Common
{
    public static class Extensions
    {
        /// <summary>
        /// Same as "obj is null".
        /// </summary>
        /// <param name="obj">Any object.</param>
        /// <returns>Returns 'true' if the object is 'null'.</returns>
        public static bool IsNull<T>(this T obj)
            where T : class
        {
            return obj is null;
        }

        /// <summary>
        /// Same as "!(obj is null)".
        /// </summary>
        /// <param name="obj">Any object.</param>
        /// <returns>Returns 'true' if the object is not 'null'.</returns>
        public static bool IsNotNull<T>(this T obj)
            where T : class
        {
            return !(obj is null);
        }

        /// <summary>
        /// Tests whether an enumerable object is undefined or empty.
        /// </summary>
        /// <param name="items">An object of type 'System.Collections.IEnumerable'.</param>
        /// <returns>Returns 'true' if the object is 'null' or 'empty'.</returns>
        public static bool IsNullOrEmpty(this System.Collections.IEnumerable items)
        {
            return items.IsNull() || !items.GetEnumerator().MoveNext();
        }

        /// <summary>
        /// It is the exception-free use of the 'ToString' method.
        /// </summary>
        /// <param name="obj">Any object.</param>
        /// <returns>It returns 'null' or 'string.'</returns>
        public static string ToSafeString(this object obj)
        {
            return obj.IsNull()
                ? null
                : obj.ToString();
        }

        /// <summary>
        /// Returns a string of the specified length from the left of the string.
        /// </summary>
        /// <param name="s">Source string.</param>
        /// <param name="length">Specified length.</param>
        /// <returns>Returns a String type value.</returns>
        public static string Left(this string s, int length)
        {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring(0, length.Range(0, s.Length));
        }

        /// <summary>
        /// Returns a string of the specified length from the rigth of the string.
        /// </summary>
        /// <param name="s">Source string.</param>
        /// <param name="length">Specified length.</param>
        /// <returns>Returns a String type value.</returns>
        public static string Right(this string s, int length)
        {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring(s.Length - length.Range(0, s.Length));
        }

        /// <summary>
        /// Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
        /// </summary>
        /// <param name="s">Source string.</param>
        /// <param name="startIndex">The starting character position of a substring in this instance. It supports negative values.</param>
        /// <param name="length">The number of characters in the substring. It supports negative values.</param>
        /// <returns>Returns null if 's' is null. Otherwise, returns a string equivalent substring of the specified length from the start character position.</returns>
        public static string Mid(this string s, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(s)) {
                return s;
            }

            int endIndex = (startIndex + length).Range(0, s.Length);
            startIndex = startIndex.Range(0, s.Length);
            if (startIndex > endIndex)
            {
                // swap 'startIndex <-> endIndex'
                int n = startIndex;
                startIndex = endIndex;
                endIndex = n;
            }
            length = (endIndex - startIndex).Range(0, s.Length);

            return length == 0
                ? string.Empty
                : s.Substring(startIndex, length);
        }

        /// <summary>
        /// Replace '\r\n' characters in string with spaces.
        /// </summary>
        /// <param name="s">Source string.</param>
        /// <returns>It returns 'null' or 'string'.</returns>
        public static string RemoveNewLines(this string s)
        {
            return s.IsNull()
                ? null
                : string.Join(" ", s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        /// Multi Replace: Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="s">The string to replace.</param>
        /// <param name="oldValues">Strings to replace.</param>
        /// <param name="newValues">Strings to replace all occurrences of oldValues.</param>
        /// <param name="comparisonType">One of the enumeration values that determines how this string and value are compared.</param>
        /// <returns>A string that is equivalent to the current string except that all instances of oldValues are replaced with newValues.</returns>
        public static string Replace(this string s, string[] oldValues, string[] newValues, StringComparison comparisonType)
        {
            if (s.IsNull()) {
                return null;
            }

            if ((s.Length == 0) || oldValues.IsNullOrEmpty()) {
                return string.Empty;
            }

            StringComparer strCmp;
            RegexOptions regexOptions;
            switch (comparisonType)
            {
                case StringComparison.CurrentCulture:
                    strCmp = StringComparer.CurrentCulture;
                    regexOptions = RegexOptions.None;
                    break;
                case StringComparison.CurrentCultureIgnoreCase:
                    strCmp = StringComparer.CurrentCultureIgnoreCase;
                    regexOptions = RegexOptions.IgnoreCase;
                    break;
                case StringComparison.InvariantCulture:
                    strCmp = StringComparer.InvariantCulture;
                    regexOptions = RegexOptions.CultureInvariant;
                    break;
                case StringComparison.InvariantCultureIgnoreCase:
                    strCmp = StringComparer.InvariantCultureIgnoreCase;
                    regexOptions = RegexOptions.IgnoreCase | RegexOptions.CultureInvariant;
                    break;
                case StringComparison.Ordinal:
                    strCmp = StringComparer.Ordinal;
                    regexOptions = RegexOptions.None;
                    break;
                case StringComparison.OrdinalIgnoreCase:
                    strCmp = StringComparer.OrdinalIgnoreCase;
                    regexOptions = RegexOptions.None;
                    break;
                default:
                    strCmp = StringComparer.CurrentCulture;
                    regexOptions = RegexOptions.None;
                    break;
            }

            StringBuilder sb = new StringBuilder();
            string patern = string.Join("|", oldValues.Select(x => Regex.Escape(x)));
            Regex regex = new Regex(patern, regexOptions);
            string sNewValue = string.Empty;
            int nPos = 0, nLen, ndx2;
            foreach (Match match in regex.Matches(s))
            {
                nLen = match.Index - nPos;
                if (nLen > 0) {
                    sb.Append(s.Substring(nPos, nLen));
                }
                nPos = match.Index + match.Value.Length;

                if (!newValues.IsNullOrEmpty() && ((ndx2 = Array.FindIndex(oldValues, x => strCmp.Equals(x, match.Value))) < newValues.Length) && (ndx2 > -1))
                {
                    sb.Append(newValues[ndx2]);
                }
            }

            if (nPos < s.Length) {
                sb.Append(s.Substring(nPos));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Multi Replace: Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="oldValues">Strings to replace.</param>
        /// <param name="newValues">Strings to replace all occurrences of oldValues.</param>
        /// <param name="ignoreCase">true to ignore case during the comparison; otherwise, false.</param>
        /// <returns>A string that is equivalent to the current string except that all instances of oldValues are replaced with newValues.</returns>
        public static string Replace(this string s, string[] oldValues, string[] newValues, bool ignoreCase)
        {
            return Replace(s, oldValues, newValues, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Multi Replace: Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="oldValues">Strings to replace.</param>
        /// <param name="newValues">Strings to replace all occurrences of oldValues.</param>
        /// <returns>A string that is equivalent to the current string except that all instances of oldValues are replaced with newValues.</returns>
        public static string Replace(this string s, string[] oldValues, string[] newValues)
        {
            return Replace(s, oldValues, newValues, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Returns all exception messages.
        /// </summary>
        /// <param name="error">An object of type 'System.Exception'.</param>
        /// <returns>It returns 'null' or 'string'.</returns>
        public static string ToMessages(this Exception error)
        {
            if (error == null) {
                return null;
            }

            string message = null;
            do
            {
                if (message.IsNotNull()) {
                    message += " --> ";
                }
                // remove new lines
                message += $"{error.GetType().Name}: {error.Message.RemoveNewLines()}";
                error = error.InnerException;
            } while (error.IsNotNull());

            return message;
        }

        /// <summary>
        /// It is like the 'Clone' method. It will not throw an exception for an object that is 'null'.
        /// </summary>
        /// <typeparam name="T">Generic type derived from the "ICloneable" interface.</typeparam>
        /// <param name="obj">An object of type 'T'.</param>
        /// <returns>'null' or an instance of the object is returned.</returns>
        public static T SafeClone<T>(this T obj)
            where T : ICloneable
        {
            return (obj is ICloneable cloneableObj)
                ? (T)cloneableObj.Clone()
                : default;
        }

        /// <summary>
        /// Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional System.Collections.IEnumerable.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="source">An System.Collections.Generic.IEnumerable to return an element from.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by match, if found; otherwise, –1.</returns>
        public static int IndexOf<T>(this System.Collections.IEnumerable source, T item)
        {
            int ndx = 0;
            var comparer = System.Collections.Generic.EqualityComparer<T>.Default; // or pass in as a parameter
            foreach (object o1 in source)
            {
                if (((o1 is T) || (o1 is null)) && comparer.Equals((T)o1, item)) {
                    return ndx;
                }
                ndx++;
            }
            return -1;
        }
    }
}
