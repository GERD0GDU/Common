using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using ioCode.Common;
using System.Diagnostics;

namespace TestConsole
{
    class Program
    {
        static string DisplayText(object obj)
        {
            if (obj is string s)
            {
                // not use "s.IsNull()"
                return (s is null) ? "null" : $"\"{s.Replace("\r", "\\r").Replace("\n", "\\n").Replace("\t", new string(' ', 4))}\"";
            }
            else if (obj is byte bytVal)
                return bytVal.ToHexString("0");
            else if (obj is ushort ui16Val)
                return ui16Val.ToHexString("0");
            else if (obj is uint ui32Val)
                return ui32Val.ToHexString("0");
            else if (obj is ulong ui64Val)
                return ui64Val.ToHexString("0");
            else if (obj is decimal decVal)
                return decVal.ToString(CultureInfo.InvariantCulture);
            else if (obj is double dblVal)
                return dblVal.ToString(CultureInfo.InvariantCulture);
            else if (obj is float floatVal)
                return floatVal.ToString(CultureInfo.InvariantCulture);

            return (obj is null)
                ? "null"
                : obj.ToString();
        }

        static string DefineStringArray(string name, string[] value)
        {
            return $"string[] {name} = new string[] {{ {string.Join(", ", value.Select(x => DisplayText(x)))} }};";
        }

        static void TestExtensionsClass()
        {
            string[] strValues = new string[] { null, "line(1)\r\nline(2)", "" };

            Console.WriteLine();
            Console.WriteLine("  // The source array to use for testing.");
            Console.WriteLine($"  {DefineStringArray(nameof(strValues), strValues)}");
            Console.WriteLine();

            for (int i = 0; i < strValues.Length; i++)
            {
                Console.WriteLine($"  {nameof(strValues)}[{i}] --> {DisplayText(strValues[i])} (Length={(strValues[i] ?? "").Length});");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.IsNull)}() --> {strValues[i].IsNull()}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.IsNotNull)}() --> {strValues[i].IsNotNull()}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.IsNullOrEmpty)}() --> {strValues[i].IsNullOrEmpty()}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.ToSafeString)}() --> {DisplayText(strValues[i].ToSafeString())}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Left)}(4) --> {DisplayText(strValues[i].Left(4))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Right)}(6) --> {DisplayText(strValues[i].Right(6))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Mid)}(-1, 4) --> {DisplayText(strValues[i].Mid(-1, 4))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Mid)}(1, 4) --> {DisplayText(strValues[i].Mid(1, 4))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Mid)}(10, 6) --> {DisplayText(strValues[i].Mid(10, 6))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Mid)}(15, 100) --> {DisplayText(strValues[i].Mid(15, 100))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Mid)}(-45, 99) --> {DisplayText(strValues[i].Mid(-45, 99))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.RemoveNewLines)}() --> {DisplayText(strValues[i].RemoveNewLines())}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.Replace)}(new string[] {{ \"1\",\"2\" }}, new string[] {{ \"One\",\"Two\" }}) --> {DisplayText(strValues[i].Replace(new string[] { "1", "2" }, new string[] { "One", "Two" }))}");
                Console.WriteLine($"  {nameof(strValues)}[{i}].{nameof(Extensions.SafeClone)}() --> {DisplayText(strValues[i].SafeClone())}");
                Console.WriteLine();
            }

            // Create exception
            string s = null;
            // Act like it's a mistake.
            NullReferenceException error = new NullReferenceException(
                "Object is null.",
                new ArgumentNullException(nameof(s)) /* for test */
                );
            Console.WriteLine($"  // {nameof(Extensions.ToMessages)}");
            Console.WriteLine($"  string {nameof(s)} = {DisplayText(s)};");
            Console.WriteLine("  try");
            Console.WriteLine("  {");
            Console.WriteLine($"    {nameof(s)} = {nameof(s)}.Substring(0, 10);");
            Console.WriteLine("  }");
            Console.WriteLine("  catch (Exception error)");
            Console.WriteLine("  {");
            Console.WriteLine($"    {nameof(error)}.{nameof(Extensions.ToMessages)}() --> {DisplayText(error.ToMessages())}");
            Console.WriteLine("  }");
            Console.WriteLine();
        }

        static void TestMathExtensionsClass()
        {
            object[][] datas = new object[][]
            {
                new object[] { (sbyte)-36, (sbyte)0, sbyte.MaxValue },
                new object[] { (sbyte)-36, (sbyte)12, (sbyte)95 },
                new object[] { (sbyte)-36, (sbyte)102, (sbyte)-25 },
                new object[] { (sbyte)-36, (sbyte)-43, (sbyte)43 },

                new object[] { (short)-32700, (short)0, short.MaxValue },
                new object[] { (short)-32700, (short)12, (short)95 },
                new object[] { (short)-32700, (short)102, short.MinValue },
                new object[] { (short)-32700, (short)-43, (short)43 },

                new object[] { -1234567890, 0, int.MaxValue },
                new object[] { -1234567890, 12, 95 },
                new object[] { -1234567890, 102, int.MinValue },
                new object[] { -1234567890, -1231231231, 43 },

                new object[] { (long)-1234567890, 0, long.MaxValue },
                new object[] { (long)-1234567890, 12, 95 },
                new object[] { (long)-1234567890, 102, long.MinValue },
                new object[] { (long)-1234567890, -1231231231, 43 },

                new object[] { -1234567890d, 0d, double.MaxValue },
                new object[] { -1234567890d, 12d, 95d },
                new object[] { -1234567890d, 102d, double.MinValue },
                new object[] { -1234567890d, -1231231231d, 43d },

                new object[] { -1234567890f, 0f, float.MaxValue },
                new object[] { -1234567890f, 12f, 95d },
                new object[] { -1234567890f, 102f, float.MinValue },
                new object[] { -1234567890f, -1231231231f, 43f },

                new object[] { (byte)248, (byte)255, (byte)15 },
                new object[] { (byte)248, (byte)100, (byte)242 },
                new object[] { (byte)248, (byte)128, (byte)12 },
                new object[] { (byte)248, (byte)42, (byte)56 },

                new object[] { (ushort)248, (ushort)255, (ushort)15 },
                new object[] { (ushort)248, (ushort)100, (ushort)242 },
                new object[] { (ushort)248, (ushort)128, (ushort)12 },
                new object[] { (ushort)248, (ushort)42, (ushort)56 },

                new object[] { (uint)248, (uint)255, (uint)15 },
                new object[] { (uint)248, (uint)100, (uint)242 },
                new object[] { (uint)248, (uint)128, (uint)12 },
                new object[] { (uint)248, (uint)42, (uint)56 },

                new object[] { (ulong)248, (ulong)255, (ulong)15 },
                new object[] { (ulong)248, (ulong)100, (ulong)242 },
                new object[] { (ulong)248, (ulong)128, (ulong)12 },
                new object[] { (ulong)248, (ulong)42, (ulong)56 },

                new object[] { new TimeSpan(12,56,35), new TimeSpan(11, 20, 48), new TimeSpan(23,32,17) },
                new object[] { new TimeSpan(12,56,35), new TimeSpan(13, 25, 32), new TimeSpan(23,32,17) },
                new object[] { new TimeSpan(23,59,59), new TimeSpan(16, 48, 27), new TimeSpan(00,00,00) },
                new object[] { new TimeSpan(23,59,59), new TimeSpan(16, 48, 27), new TimeSpan(1,00,00,00) },
            };

            object InvokeRangeMethodFromType(Type t, object n, object first, object last)
            {
                System.Reflection.MethodInfo MI = typeof(MathExtensions).GetMethod("Range", new Type[] { t, t, t });
                return MI.Invoke(null, new object[] { Convert.ChangeType(n, t), Convert.ChangeType(first, t), Convert.ChangeType(last, t) });
            }

            Console.WriteLine();
            Console.WriteLine($"  {"Type",-20} {"Invoke Method",-56} {"Result",16}");
            Console.WriteLine($"  {new string('-', 94)}");
            foreach (var data in datas)
            {
                Console.WriteLine($"  {data[0].GetType().FullName,-20} {$"({data[0]}).{nameof(MathExtensions.Range)}({data[1]}, {data[2]})",-56} {InvokeRangeMethodFromType(data[0].GetType(), data[0], data[1], data[2]),16}");
            }
            Console.WriteLine();
        }

        static void TestConvertExtensionClass()
        {
            Console.WriteLine();
            Console.WriteLine("  // All extended methods used for conversion operations do not");
            Console.WriteLine("  // offer any guarantees.");
            Console.WriteLine("  // None of the extended methods throw exceptions.");
            Console.WriteLine("  // The extended method returns '0' (zero) if the conversion fails.");
            Console.WriteLine("  // When the conversion is successful, it returns a value in the");
            Console.WriteLine("  // minimum and maximum range of the converted type.");
            Console.WriteLine();

            string[] datas = new string[]
            {
                "0xF1AC16D4", 
                "&HE742ACF1DA12C24D",
                "-1.896541224756756E+19",
                "1.978E+9",
                "9865412365465",
                "-123654897998412",
                "blabla",
                double.MaxValue.ToString(CultureInfo.InvariantCulture),
                (double.MaxValue - 1E+294d).ToString(CultureInfo.InvariantCulture),
                $"0x{ulong.MaxValue:X8}",
                ulong.MaxValue.ToString(),
                Math.PI.ToString(CultureInfo.InvariantCulture),
            };

            System.Reflection.MethodInfo[] converterMethods = typeof(ConversionExtensions)
                .GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(x => x.GetParameters().Length == 2 && x.GetParameters()[0].ParameterType == typeof(string) && x.GetParameters()[1].ParameterType == typeof(IFormatProvider))
                .ToArray();

            Console.WriteLine();
            Console.WriteLine($"  {"Invoke Method",-38} {"Result",32}");
            Console.WriteLine($"  {new string('-', 71)}");
            foreach (string data in datas)
            {
                foreach(System.Reflection.MethodInfo mi in converterMethods)
                {
                    Console.WriteLine($"  {$"{DisplayText(data)}.{mi.Name}()",-38} {$"{DisplayText(mi.Invoke(null, new object[] { data, CultureInfo.InvariantCulture }))}",32}");
                }
                Console.WriteLine();
            }

            // HexString converter
            void WriteHexStringLine<T>(T value, string fmt)
            {
                System.Reflection.MethodInfo mi = typeof(ConversionExtensions).GetMethod("ToHexString", new Type[] { typeof(T), typeof(string) });
                Console.WriteLine($"  {typeof(T).FullName,-20} {DisplayText(fmt),-8} {$"({value}).{nameof(ConversionExtensions.ToHexString)}({DisplayText(fmt)})",-40} {mi.Invoke(null, new object[] { value, fmt} ),24}");
            }

            Console.WriteLine();
            Console.WriteLine("  // Converts an x-bit unsigned integer to a hexadecimal string.");
            Console.WriteLine();
            Console.WriteLine($"  {"Type",-20} {"Format",-8} {"Invoke Method",-40} {"Result",24}");
            Console.WriteLine($"  {new string('-', 95)}");
            WriteHexStringLine((byte)0xE, null);
            WriteHexStringLine((byte)0xE, "0");
            WriteHexStringLine((byte)0xE, "H");
            Console.WriteLine();
            WriteHexStringLine((ushort)0x9FE, null);
            WriteHexStringLine((ushort)0x9FE, "0");
            WriteHexStringLine((ushort)0x9FE, "H");
            Console.WriteLine();
            WriteHexStringLine((uint)0x9FE12, null);
            WriteHexStringLine((uint)0x9FE12, "0");
            WriteHexStringLine((uint)0x9FE12, "H");
            Console.WriteLine();
            WriteHexStringLine((ulong)0x9FE123456, null);
            WriteHexStringLine((ulong)0x9FE123456, "0");
            WriteHexStringLine((ulong)0x9FE123456, "H");
            Console.WriteLine();
        }

        static void TestMacroClass()
        {
            Console.WriteLine();
            DateTime dtNow = DateTime.Now;
            Macro.Current.CultureInfo = CultureInfo.InvariantCulture;

            string[][] sAryMacros = new string[][]
            {
                new string[]{ "${h}", "12-hour clock hour (e.g. 4)" },
                new string[]{ "${hh}", "12-hour clock, with a leading 0 (e.g. 06)" },
                new string[]{ "${H}", "24-hour clock hour (e.g. 15)" },
                new string[]{ "${HH}", "24-hour clock hour, with a leading 0 (e.g. 22)" },
                new string[]{ "${m}", "Minutes" },
                new string[]{ "${mm}", "Minutes with a leading zero" },
                new string[]{ "${s}", "Seconds" },
                new string[]{ "${ss}", "Seconds with a leading zero" },
                new string[]{ "${f}", "Represents the tenths of a second" },
                new string[]{ "${ff}", "Represents the two most significant digits of the seconds' fraction in date and time" },
                new string[]{ "${fff}", "Milliseconds" },
                new string[]{ "${t}", "Abbreviated AM / PM (e.g. A or P)" },
                new string[]{ "${tt}", "AM / PM (e.g. AM or PM)" },
                new string[]{ "${d}", "Represents the day of the month as a number from 1 through 31" },
                new string[]{ "${dd}", "Represents the day of the month as a number from 01 through 31" },
                new string[]{ "${ddd}", "Represents the abbreviated name of the day (Mon, Tues, Wed, etc)" },
                new string[]{ "${dddd}", "Represents the full name of the day (Monday, Tuesday, etc)" },
                new string[]{ "${wd}", "Represents the day of the week (e.g. 7 for Sunday)" },
                new string[]{ "${M}", "Month number (eg. 3)" },
                new string[]{ "${MM}", "Month number with leading zero (eg. 04)" },
                new string[]{ "${MMM}", "Abbreviated Month Name (e.g. Dec)" },
                new string[]{ "${MMMM}", "Full month name (e.g. December)" },
                new string[]{ "${y}", "Year, no leading zero (e.g. 2015 would be 15)" },
                new string[]{ "${yy}", "Year, leading zero (e.g. 2015 would be 015)" },
                new string[]{ "${yyy}", "Year, (e.g. 2015)" },
                new string[]{ "${yyyy}", "Year, (e.g. 2015)" },
                new string[]{ "${z}", "With DateTime values represents the signed offset of the local operating system's time zone from Coordinated Universal Time (UTC), measured in hours. (e.g. +6)" },
                new string[]{ "${zz}", "As z, but with leading zero (e.g. +06)" },
                new string[]{ "${zzz}", "With DateTime values represents the signed offset of the local operating system's time zone from UTC, measured in hours and minutes. (e.g. +06:00)" },
            };

            Console.WriteLine("  Macro.Current.CultureInfo = System.Globalization.CultureInfo.InvariantCulture;");
            Console.WriteLine($"  DateTime.Now --> {DisplayText(dtNow.ToString("yyyy, dd MMMM yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture))}");
            Console.WriteLine();

            const int maxDescrLen = 70;
            Console.WriteLine($"  {"Format",-16} {"Result",-16} {"Description",-maxDescrLen}");
            Console.WriteLine($"  {new string('-', 34 + maxDescrLen)}");
            foreach (string[] item in sAryMacros)
            {
                string descr = item[1];
                List<string> descrList = new List<string>();
                do
                {
                    if (descr.Length >= maxDescrLen)
                    {
                        int ndx = descr.LastIndexOf(" ", maxDescrLen);
                        if (ndx == -1)
                        {
                            descrList.Add(descr);
                            descr = "";
                        }
                        else
                        {
                            descrList.Add(descr.Left(ndx));
                            descr = descr.Substring(ndx + 1);
                        }
                    }
                    else
                    {
                        descrList.Add(descr);
                        descr = "";
                    }
                } while (descr.Length > 0);

                Console.WriteLine($"  {$"{item[0],-16}"} {DisplayText(Macro.Current.Compile(item[0], dtNow)),-16} {descrList[0],-maxDescrLen}");
                for (int i = 1; i < descrList.Count; i++)
                {
                    Console.WriteLine($"  {"",-16} {"",-16} {descrList[i],-maxDescrLen}");
                }
            }

            int index = 0;
            string[] sAryExtra = new string[]
            {
                ".\\${yyyy}\\${MMMM}\\log_${yyyy.MM.dd HH.mm.ss}.log",
                "file_${yyyyMMddHHmmssfff}.txt",
                "${dddd, dd MMMM yyyy HH:mm:ss}",
                "${ddd, dd MMM yyy HH:mm:ss} GMT",
                "${yyyy-MM-ddTHH:mm:ss.fffzzz}",
            };

            Console.WriteLine();
            Console.WriteLine("  Examples:");
            foreach(string sFormat in sAryExtra)
            {
                Console.WriteLine($"  {$"{++index})",-4} \"{$"{sFormat}"}\" --> {DisplayText(Macro.Current.Compile(sFormat, dtNow))}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var testMethods = new[]
            {
                new { name = typeof(Extensions).FullName, call_method = new Action(() => TestExtensionsClass()) },
                new { name = typeof(MathExtensions).FullName, call_method = new Action(() => TestMathExtensionsClass()) },
                new { name = typeof(ConversionExtensions).FullName, call_method = new Action(() => TestConvertExtensionClass()) },
                new { name = typeof(Macro).FullName, call_method = new Action(() => TestMacroClass()) },
            };

            int ndx = 0;
            int nTotal = testMethods.Length;
            foreach(var test in testMethods)
            {
                Console.Clear();
                Console.WriteLine(new string('#', 100));
                Console.WriteLine($"{++ndx}/{nTotal}. '{test.name}' Test");
                test.call_method.Invoke();

                Console.WriteLine(ndx == nTotal ? "Press enter to exit." : "Press enter to next.");
                Console.ReadLine();
            }
        }
    }
}
