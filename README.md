<p align="center">
  <a href="https://iocode.co.uk/"><img src="assets/logo.png" height=64></a>
</p>

## <div align="center"><b><a href="README.md">English</a> | <a href="README_TR.md">Türkçe</a></b></div>

ioCode.Common C# Library
========================

A library that provides extended methods for the practical use of conversions.

**Warning** This sample requires Microsoft Visual Studio Community 2019 .NET Framework 4.5 or a later version (any SKU).

To get a copy of Visual Studio, go to [Visual Studio Downloads](http://go.microsoft.com/fwlink/p/?linkid=301697).

Classes
-------

[ioCode.Common](https://github.com/GERD0GDU/Common) library contains the following classes.
| Class | Description |
| :--- | :--- |
| [ConversionExtensions](#iocodecommonconversionextensions) | Converts the string representation of a number to sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long. |
| [Extensions](#iocodecommonextensions) | Provides extended methods for general uses. |
| [Macro](#iocodecommonmacro) | A class that outputs strings by compiling specified custom date-time formats. |
| [MathExtensions](#iocodecommonmathextensions) | It provides extended methods for variables sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long, TimeSpan, DateTime that enforce minimum and maximum range. |

ioCode.Common.ConversionExtensions
----------------------------------

#### Warning

- All extended methods used for conversion operations do not throw any error exceptions.
- For this reason, there is no guarantee of the method result.
- The extended method returns '0' (zero) if the conversion fails.
- When the conversion is successful, it returns a value in the minimum and maximum range of the converted type.

### Methods

| Method | Description |
| :--- | :--- |
| [ToDecimal(String, IFormatProvider)](#todecimal-method) | Converts the string representation of a number to its System.Decimal equivalent using the specified culture-specific format information. |
| [ToDecimal(String)](#todecimal-method)  | Converts the string representation of a number to its System.Decimal equivalent. |
| [ToDouble(String, IFormatProvider)](#todouble-method) | Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent. |
| [ToDouble(String)](#todouble-method) | Converts the string representation of a number to its double-precision floating-point number equivalent. |
| [ToSingle(String, IFormatProvider)](#tosingle-method) | Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent. |
| [ToSingle(String)](#tosingle-method) | Converts the string representation of a number to its single-precision floating-point number equivalent. |
| [ToSByte(String, IFormatProvider)](#tosbyte-method) | Converts the string representation of a number in a specified culture-specific format to its 8-bit signed integer equivalent. |
| [ToSByte(String)](#tosbyte-method) | Converts the string representation of a number to its 8-bit signed integer equivalent. |
| [ToInt16(String, IFormatProvider)](#toint16-method) | Converts the string representation of a number in a specified culture-specific format to its 16-bit signed integer equivalent. |
| [ToInt16(String)](#toint16-method) | Converts the string representation of a number to its 16-bit signed integer equivalent. |
| [ToInt32(String, IFormatProvider)](#toint32-method) | Converts the string representation of a number in a specified culture-specific format to its 32-bit signed integer equivalent. |
| [ToInt32(String)](#toint32-method) | Converts the string representation of a number to its 32-bit signed integer equivalent. |
| [ToInt64(String, IFormatProvider)](#toint64-method) | Converts the string representation of a number in a specified culture-specific format to its 64-bit signed integer equivalent. |
| [ToInt64(String)](#toint64-method) | Converts the string representation of a number to its 64-bit signed integer equivalent. |
| [ToByte(String, IFormatProvider)](#tobyte-method) | Converts the string representation of a number in a specified culture-specific format to its System.Byte equivalent. |
| [ToByte(String)](#tobyte-method) | Converts the string representation of a number to its System.Byte equivalent. |
| [ToUInt16(String, IFormatProvider)](#touint16-method) | Converts the string representation of a number in a specified culture-specific format to its 16-bit unsigned integer equivalent. |
| [ToUInt16(String)](#touint16-method) | Converts the string representation of a number to its 16-bit unsigned integer equivalent. |
| [ToUInt32(String, IFormatProvider)](#touint32-method) | Converts the string representation of a number in a specified culture-specific format to its 32-bit unsigned integer equivalent. |
| [ToUInt32(String)](#touint32-method) | Converts the string representation of a number to its 32-bit unsigned integer equivalent. |
| [ToUInt64(String, IFormatProvider)](#touint64-method) | Converts the string representation of a number in a specified culture-specific format to its 64-bit unsigned integer equivalent. |
| [ToUInt64(String)](#touint64-method) | Converts the string representation of a number to its 64-bit unsigned integer equivalent. |
| [ToHexString(Byte, String)](#tohexstring-method) | Converts an 8-bit unsigned integer to a hexadecimal string according to the format. |
| [ToHexString(Byte)](#tohexstring-method) | Converts an 8-bit unsigned integer to a hexadecimal string. |
| [ToHexString(UInt16, String)](#tohexstring-method) | Converts an 16-bit unsigned integer to a hexadecimal string according to the format. |
| [ToHexString(UInt16)](#tohexstring-method) | Converts an 16-bit unsigned integer to a hexadecimal string. |
| [ToHexString(UInt32, String)](#tohexstring-method) | Converts an 32-bit unsigned integer to a hexadecimal string according to the format. |
| [ToHexString(UInt32)](#tohexstring-method) | Converts an 32-bit unsigned integer to a hexadecimal string. |
| [ToHexString(UInt64, String)](#tohexstring-method) | Converts an 64-bit unsigned integer to a hexadecimal string according to the format. |
| [ToHexString(UInt64)](#tohexstring-method) | Converts an 64-bit unsigned integer to a hexadecimal string. |

### ToDecimal Method

#### Definition
Namespace: ioCode.Common <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToDecimal(String, IFormatProvider)** | Converts the string representation of a number to its System.Decimal equivalent using the specified culture-specific format information. |
| **ToDecimal(String)** | Converts the string representation of a number to its System.Decimal equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Decimal](https://docs.microsoft.com/en-US/dotnet/api/system.decimal) <br>
The [System.Decimal](https://docs.microsoft.com/en-US/dotnet/api/system.decimal) number equivalent to the number contained in s as specified by provider.

#### Examples
```csharp
System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
decimal decVal = "1.9876E+9".ToDecimal();
System.Console.WriteLine("\"1.9876E+9\" --> {0}", decVal);
decVal = "79228162514264337593543950334".ToDecimal();
System.Console.WriteLine("\"79228162514264337593543950334\" --> {0}", decVal);
decVal = "0x123456789ABCDEF0".ToDecimal();
System.Console.WriteLine("\"0x123456789ABCDEF0\" --> {0} (0x{1:X16})", decVal, (ulong)decVal);
decVal = "&H9ABCDEF012345678".ToDecimal();
System.Console.WriteLine("\"&H9ABCDEF012345678\" --> {0} (0x{1:X16})", decVal, (ulong)decVal);
```
Console output will be as follows.
```
"1.9876E+9" --> 1987600000
"79228162514264337593543950334" --> 79228162514264337593543950334
"0x123456789ABCDEF0" --> 1311768467463790320 (0x123456789ABCDEF0)
"&H9ABCDEF012345678" --> 11150031900141442680 (0x9ABCDEF012345678)
```

### ToDouble Method

#### Definition
Namespace: ioCode.Common <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToDouble(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its double-precision floating-point number equivalent. |
| **ToDouble(String)** | Converts the string representation of a number to its double-precision floating-point number equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Double](https://docs.microsoft.com/en-US/dotnet/api/system.double) <br>
The [System.Double](https://docs.microsoft.com/en-US/dotnet/api/system.double) number equivalent to the number contained in s as specified by provider.

#### Examples
```csharp
// change current culture
System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
double dblVal = "1.9876E+9".ToDouble();
System.Console.WriteLine("\"1.9876E+9\" --> {0}", dblVal);
dblVal = "79228162514264337593543950334".ToDouble();
System.Console.WriteLine("\"79228162514264337593543950334\" --> {0}", dblVal);
dblVal = "0x123456789ABCDEF0".ToDouble();
System.Console.WriteLine("\"0x123456789ABCDEF0\" --> {0} (0x{1:X16})", dblVal, (ulong)dblVal);
dblVal = "&H9ABCDEF012345678".ToDouble();
System.Console.WriteLine("\"&H9ABCDEF012345678\" --> {0} (0x{1:X16})", dblVal, (ulong)dblVal);
```
Console output will be as follows.
```
"1.9876E+9" --> 1987600000
"79228162514264337593543950334" --> 7.92281625142643E+28
"0x123456789ABCDEF0" --> 1.31176846746379E+18 (0x123456789ABCDF00)
"&H9ABCDEF012345678" --> 1.11500319001414E+19 (0x9ABCDEF012345800)
```

### ToSingle Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToSingle(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its single-precision floating-point number equivalent.
| **ToSingle(String)** | Converts the string representation of a number to its single-precision floating-point number equivalent.

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Single](https://docs.microsoft.com/en-US/dotnet/api/system.single) <br>
The [System.Single](https://docs.microsoft.com/en-US/dotnet/api/system.single) number equivalent to the number contained in s as specified by provider.

### ToSByte Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToSByte(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 8-bit signed integer equivalent. |
| **ToSByte(String)** | Converts the string representation of a number to its 8-bit signed integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[SByte](https://docs.microsoft.com/en-US/dotnet/api/system.sbyte) <br>
The [System.SByte](https://docs.microsoft.com/en-US/dotnet/api/system.sbyte) number equivalent to the number contained in s as specified by provider.

### ToInt16 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToInt16(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 16-bit signed integer equivalent. |
| **ToInt16(String)** | Converts the string representation of a number to its 16-bit signed integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Int16](https://docs.microsoft.com/en-US/dotnet/api/system.int16) <br>
The [System.Int16](https://docs.microsoft.com/en-US/dotnet/api/system.int16) number equivalent to the number contained in s as specified by provider.

### ToInt32 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToInt32(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 32-bit signed integer equivalent. |
| **ToInt32(String)** | Converts the string representation of a number to its 32-bit signed integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Int32](https://docs.microsoft.com/en-US/dotnet/api/system.int32) <br>
The [System.Int32](https://docs.microsoft.com/en-US/dotnet/api/system.int32) number equivalent to the number contained in s as specified by provider.

### ToInt64 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToInt64(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 64-bit signed integer equivalent. |
| **ToInt64(String)** | Converts the string representation of a number to its 64-bit signed integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Int64](https://docs.microsoft.com/en-US/dotnet/api/system.int64) <br>
The [System.Int64](https://docs.microsoft.com/en-US/dotnet/api/system.int64) number equivalent to the number contained in s as specified by provider.

### ToByte Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToByte(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its System.Byte equivalent. |
| **ToByte(String)** | Converts the string representation of a number to its System.Byte equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[Byte](https://docs.microsoft.com/en-US/dotnet/api/system.byte) <br>
The [System.Byte](https://docs.microsoft.com/en-US/dotnet/api/system.byte) number equivalent to the number contained in s as specified by provider.

### ToUInt16 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToUInt16(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 16-bit unsigned integer equivalent. |
| **ToUInt16(String)** | Converts the string representation of a number to its 16-bit unsigned integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[UInt16](https://docs.microsoft.com/en-US/dotnet/api/system.uint16) <br>
The [System.UInt16](https://docs.microsoft.com/en-US/dotnet/api/system.uint16) number equivalent to the number contained in s as specified by provider.

### ToUInt32 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToUInt32(String, IFormatProvider)** | Converts the string representation of a number in a specified culture-specific format to its 32-bit unsigned integer equivalent. |
| **ToUInt32(String)** | Converts the string representation of a number to its 32-bit unsigned integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[UInt32](https://docs.microsoft.com/en-US/dotnet/api/system.uint32) <br>
The [System.UInt32](https://docs.microsoft.com/en-US/dotnet/api/system.uint32) number equivalent to the number contained in s as specified by provider.

### ToUInt64 Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToUInt64(IFormatProvider provider)** | Converts the string representation of a number in a specified culture-specific format to its 64-bit unsigned integer equivalent. |
| **ToUInt64()** | Converts the string representation of a number to its 64-bit unsigned integer equivalent. |

#### Parameters
**s**: The [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) representation of the number to convert. <br>
**provider**: An [System.IFormatProvider](https://docs.microsoft.com/en-US/dotnet/api/system.iformatprovider) that supplies culture-specific parsing information about s.

#### Return
[UInt64](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) <br>
The [System.UInt64](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) number equivalent to the number contained in s as specified by provider.

### ToHexString Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Extended method that converts [byte](https://docs.microsoft.com/en-US/dotnet/api/system.byte), [ushort](https://docs.microsoft.com/en-US/dotnet/api/system.uint16), [uint](https://docs.microsoft.com/en-US/dotnet/api/system.uin32) or [ulong](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) types to hexadecimal strings.

#### Overloads
| Method | Description |
| :--- | :--- |
| **ToHexString(Byte, String)** | Converts an 8-bit unsigned integer to a hexadecimal string according to the format. |
| **ToHexString(Byte)** | Converts an 8-bit unsigned integer to a hexadecimal string. |
| **ToHexString(UInt16, String)** | Converts an 16-bit unsigned integer to a hexadecimal string according to the format. |
| **ToHexString(UInt16)** | Converts an 16-bit unsigned integer to a hexadecimal string. |
| **ToHexString(UInt32, String)** | Converts an 32-bit unsigned integer to a hexadecimal string according to the format. |
| **ToHexString(UInt32)** | Converts an 32-bit unsigned integer to a hexadecimal string. |
| **ToHexString(UInt64, String)** | Converts an 64-bit unsigned integer to a hexadecimal string according to the format. |
| **ToHexString(UInt64)** | Converts an 64-bit unsigned integer to a hexadecimal string. |

#### Parameters
**n**: A [byte](https://docs.microsoft.com/en-US/dotnet/api/system.byte), [ushort](https://docs.microsoft.com/en-US/dotnet/api/system.uint16), [uint](https://docs.microsoft.com/en-US/dotnet/api/system.uin32) or [ulong](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) that represents the number to convert. <br>
**format**: A [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) value in the form of "0" or "H" can be specified.

#### Return
[String](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) <br>
Returns a hexadecimal [string](https://docs.microsoft.com/en-US/dotnet/api/system.string) value based on the format value.

#### Examples
```csharp
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString() --> {0}", (ulong.MaxValue >> 9).ToHexString());
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString(\"0\") --> {0}", (ulong.MaxValue >> 9).ToHexString("0"));
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString(\"H\") --> {0}", (ulong.MaxValue >> 9).ToHexString("H"));
```
Console output will be as follows.
```
(ulong.MaxValue >> 9).ToHexString() --> 7FFFFFFFFFFFFF
(ulong.MaxValue >> 9).ToHexString("0") --> 0x007FFFFFFFFFFFFF
(ulong.MaxValue >> 9).ToHexString("H") --> &H007FFFFFFFFFFFFF
```

ioCode.Common.Extensions
------------------------

Provides extended methods for general uses.

### Methods

| Method | Description |
| :--- | :--- |
| [IsNull\<T\>(T)](#isnullt-method) | Tests whether any object is null. Same as "obj is null". |
| [IsNotNull\<T\>(T)](#isnotnullt-method) | Tests whether any object is not null. Same as "!(obj is null)". |
| [IsNullOrEmpty(IEnumerable)](#isnullorempty-method) | Tests whether any object derived from the "[System.Collections.IEnumerable](https://docs.microsoft.com/en-US/dotnet/api/system.collections.ienumerable)" interface is null or empty. |
| [ToSafeString(Object)](#tosafestring-method) | It's like ToString() but doesn't throw an exception even if the object is null. |
| [Left(String, Int32)](#left-method) | Returns a string of the specified length from the left of the string. It's like "[System.String.Substring](https://docs.microsoft.com/en-US/dotnet/api/system.string.substring)" but it doesn't throw an exception. |
| [Right(String, Int32)](#right-method) | Returns a string of the specified length from the rigth of the string. |
| [Mid(String, Int32, Int32)](#mid-method) | Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length. |
| [RemoveNewLines(String)](#removenewlines-method) | Replace '\r\n' characters in string with spaces. |
| [Replace(String, String\[\], String\[\], StringComparison)](#replace-method) | A comparison option is provided for replacement operations. |
| [Replace(String, String\[\], String\[\], bool)](#replace-method) | A case sensitivity option is provided for replacement operations. |
| [Replace(String, String\[\], String\[\])](#replace-method) | It does a case sensitive replacement. |
| [ToMessagees(Exception)](#tomessages-method) | Returns all exception messages. Including internal exceptions. |
| [SafeClone\<T\>(T)](#safeclonet-method) | It is like the 'Clone' method. It will not throw an exception for an object that is 'null'. |
| [IndexOf\<T\>(IEnumerable, T)](#indexoft-method) | Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional [IEnumerable](https://docs.microsoft.com/en-US/dotnet/api/system.collections.ienumerable). |

### IsNull\<T\> Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Tests whether any object is null. Same as "obj is null".
```csharp
public static bool IsNull<T>(this T obj) where T : class
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.IsNull() --> {0}\r\n", s.IsNull());
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.IsNull() --> {0}\r\n", s.IsNull());
s = "blabla";
System.Console.WriteLine("s = \"blabla\";");
System.Console.WriteLine(">> s.IsNull() --> {0}\r\n", s.IsNull());
```
Console output will be as follows.
```
string s = null;
>> s.IsNull() --> True

s = "";
>> s.IsNull() --> False

s = "blabla";
>> s.IsNull() --> False

```

### IsNotNull\<T\> Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Tests whether any object is not null. Same as "!(obj is null)".
```csharp
public static bool IsNotNull<T>(this T obj) where T : class
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.IsNotNull() --> {0}\r\n", s.IsNotNull());
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.IsNotNull() --> {0}\r\n", s.IsNotNull());
s = "blabla";
System.Console.WriteLine("s = \"blabla\";");
System.Console.WriteLine(">> s.IsNotNull() --> {0}\r\n", s.IsNotNull());
```
Console output will be as follows.
```
string s = null;
>> s.IsNotNull() --> False

s = "";
>> s.IsNotNull() --> True

s = "blabla";
>> s.IsNotNull() --> True

```

### IsNullOrEmpty Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Tests whether any object derived from the "[System.Collections.IEnumerable](https://docs.microsoft.com/en-US/dotnet/api/system.collections.ienumerable)" interface is null or empty.
```csharp
public static bool IsNullOrEmpty(this System.Collections.IEnumerable items)
```

#### Examples
```csharp
string s = "";
System.Console.WriteLine("string s = \"\";");
System.Console.WriteLine(">> s.IsNullOrEmpty() --> {0}\r\n", s.IsNullOrEmpty());
s = "blabla";
System.Console.WriteLine("s = \"blabla\";");
System.Console.WriteLine(">> s.IsNullOrEmpty() --> {0}\r\n", s.IsNullOrEmpty());
object[] objArray = new object[0];
System.Console.WriteLine("object[] objArray = new object[0];");
System.Console.WriteLine(">> objArray.IsNullOrEmpty() --> {0}\r\n", objArray.IsNullOrEmpty());
objArray = new object[] { null };
System.Console.WriteLine("objArray = new object[] { null };");
System.Console.WriteLine(">> objArray.IsNullOrEmpty() --> {0}\r\n", objArray.IsNullOrEmpty());
```
Console output will be as follows.
```
s = "";
>> s.IsNullOrEmpty() --> True

s = "blabla";
>> s.IsNullOrEmpty() --> False

objArray = new object[0];
>> objArray.IsNullOrEmpty() --> True

objArray = new object[] { null };
>> objArray.IsNullOrEmpty() --> False

```

### ToSafeString Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

It's like ToString() but doesn't throw an exception even if the object is null.
```csharp
public static string ToSafeString(this object obj)
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.ToSafeString() --> {0}\r\n", s.ToSafeString() ?? "null");
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.ToSafeString() --> \"{0}\"\r\n", s.ToSafeString());
s = "blabla";
System.Console.WriteLine("s = \"blabla\";");
System.Console.WriteLine(">> s.ToSafeString() --> \"{0}\"\r\n", s.ToSafeString());
```
Console output will be as follows.
```
string s = null;
>> s.ToSafeString() --> null

s = "";
>> s.ToSafeString() --> ""

s = "blabla";
>> s.ToSafeString() --> "blabla"

```

### Left Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Returns a string of the specified length from the left of the string. It's like "[System.String.Substring](https://docs.microsoft.com/en-US/dotnet/api/system.string.substring)" but it doesn't throw an exception.
```csharp
public static string Left(this string s, int length)
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.Left(3) --> {0}\r\n", s.Left(3) ?? "null");
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.Left(3) --> \"{0}\"\r\n", s.Left(3));
s = "blabla";
System.Console.WriteLine("s = \"blabla\";");
System.Console.WriteLine(">> s.Left(3) --> \"{0}\"\r\n", s.Left(3));
```
Console output will be as follows.
```
string s = null;
>> s.Left(3) --> null

s = "";
>> s.Left(3) --> ""

s = "blabla";
>> s.Left(3) --> "bla"

```

### Right Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Returns a string of the specified length from the rigth of the string.
```csharp
public static string Right(this string s, int length)
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.Right(3) --> {0}\r\n", s.Right(3) ?? "null");
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.Right(3) --> \"{0}\"\r\n", s.Right(3));
s = "abcdefg";
System.Console.WriteLine("s = \"abcdefg\";");
System.Console.WriteLine(">> s.Right(3) --> \"{0}\"\r\n", s.Right(3));
```
Console output will be as follows.
```
string s = null;
>> s.Right(3) --> null

s = "";
>> s.Right(3) --> ""

s = "abcdefg";
>> s.Right(3) --> "efg"

```

### Mid Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.
```csharp
public static string Mid(this string s, int startIndex, int length)
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.Mid(-1, 4) --> {0}\r\n", s.Mid(-1, 4) ?? "null");
s = "";
System.Console.WriteLine("s = \"\"; // Len:0");
System.Console.WriteLine(">> s.Mid(-1, 4) --> \"{0}\"", s.Mid(-1, 4));
System.Console.WriteLine(">> s.Mid(-1, -3) --> \"{0}\"", s.Mid(-1, -3));
System.Console.WriteLine(">> s.Mid(4, -3) --> \"{0}\"", s.Mid(4, -3));
System.Console.WriteLine(">> s.Mid(1, 0) --> \"{0}\"", s.Mid(1, 0));
System.Console.WriteLine(">> s.Mid(1, 40) --> \"{0}\"", s.Mid(1, 40));
System.Console.WriteLine(">> s.Mid(2, 3) --> \"{0}\"", s.Mid(2, 3));
System.Console.WriteLine(">> s.Mid(7, 1) --> \"{0}\"", s.Mid(7, 1));
System.Console.WriteLine(">> s.Mid(8, -3) --> \"{0}\"", s.Mid(8, -3));
System.Console.WriteLine(">> s.Mid(8, 1) --> \"{0}\"\r\n", s.Mid(8, 1));
s = "ABCDEFGH";
System.Console.WriteLine("s = \"ABCDEFGH\"; // Len:{0}", s.Length);
System.Console.WriteLine(">> s.Mid(-1, 4) --> \"{0}\"", s.Mid(-1, 4));
System.Console.WriteLine(">> s.Mid(-1, -3) --> \"{0}\"", s.Mid(-1, -3));
System.Console.WriteLine(">> s.Mid(4, -3) --> \"{0}\"", s.Mid(4, -3));
System.Console.WriteLine(">> s.Mid(1, 0) --> \"{0}\"", s.Mid(1, 0));
System.Console.WriteLine(">> s.Mid(1, 40) --> \"{0}\"", s.Mid(1, 40));
System.Console.WriteLine(">> s.Mid(2, 3) --> \"{0}\"", s.Mid(2, 3));
System.Console.WriteLine(">> s.Mid(7, 1) --> \"{0}\"", s.Mid(7, 1));
System.Console.WriteLine(">> s.Mid(8, -3) --> \"{0}\"", s.Mid(8, -3));
System.Console.WriteLine(">> s.Mid(8, 1) --> \"{0}\"\r\n", s.Mid(8, 1));
```
Console output will be as follows.
```
string s = null;
>> s.Mid(-1, 4) --> null

s = ""; // Len:0
>> s.Mid(-1, 4) --> ""
>> s.Mid(-1, -3) --> ""
>> s.Mid(4, -3) --> ""
>> s.Mid(1, 0) --> ""
>> s.Mid(1, 40) --> ""
>> s.Mid(2, 3) --> ""
>> s.Mid(7, 1) --> ""
>> s.Mid(8, -3) --> ""
>> s.Mid(8, 1) --> ""

s = "ABCDEFGH"; // Len:8
>> s.Mid(-1, 4) --> "ABC"
>> s.Mid(-1, -3) --> ""
>> s.Mid(4, -3) --> "BCD"
>> s.Mid(1, 0) --> ""
>> s.Mid(1, 40) --> "BCDEFGH"
>> s.Mid(2, 3) --> "CDE"
>> s.Mid(7, 1) --> "H"
>> s.Mid(8, -3) --> "FGH"
>> s.Mid(8, 1) --> ""

```

### RemoveNewLines Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Replace '\r\n' characters in string with spaces.
```csharp
public static string RemoveNewLines(this string s)
```

#### Examples
```csharp
string s = null;
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.RemoveNewLines() --> {0}\r\n", s.RemoveNewLines() ?? "null");
s = "";
System.Console.WriteLine("s = \"\";");
System.Console.WriteLine(">> s.RemoveNewLines() --> \"{0}\"\r\n", s.RemoveNewLines());
s = "abc\rdefg\n1234\r\n5678";
System.Console.WriteLine("s = \"abc\\rdefg\\n1234\\r\\n5678\";");
System.Console.WriteLine(">> s.RemoveNewLines() --> \"{0}\"\r\n", s.RemoveNewLines());
```
Console output will be as follows.
```
string s = null;
>> s.RemoveNewLines() --> null

s = "";
>> s.RemoveNewLines() --> ""

s = "abc\rdefg\n1234\r\n5678";
>> s.RemoveNewLines() --> "abc defg 1234 5678"

```

### Replace Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string. <br>
This method replace multiple strings at once.

#### Overloads
| Method | Description |
| :--- | :--- |
| **Replace(String, String[], String[], StringComparison)** | A comparison option is provided for replacement operations. |
| **Replace(String, String[], String[], bool)** | A case sensitivity option is provided for replacement operations. |
| **Replace(String, String[], String[])** | It does a case sensitive replacement. |

#### Parameters
| Name | Type | Description |
| :--- | :--- | :--- |
| **s** | [String](https://docs.microsoft.com/en-US/dotnet/api/system.string) | The string to replace. |
| **oldValues** | String[] | The string array to be replaced. |
| **newValues** | String[] | The string to replace all occurrences of oldValues. |
| **comparisonType** | [StringComparison](https://docs.microsoft.com/en-US/dotnet/api/system.stringcomparison) | One of the enumeration values that determines how this string and value are compared. |
| **ignoreCase** | [Boolean](https://docs.microsoft.com/en-US/dotnet/api/system.boolean) | true to ignore case during the comparison; otherwise, false. |

#### Return
[String](https://docs.microsoft.com/en-US/dotnet/api/system.string) <br>
Returns an instance of the replaced string as a string type.

#### Examples
```csharp
string[] aryFind = new string[] { "one", "two", "1", "2" };
string[] aryReplace = new string[] { "1", "2", "one", "Two" };
string s = null;            
System.Console.WriteLine("string[] aryFind = new string[] { \"one\", \"two\", \"1\", \"2\" };");
System.Console.WriteLine("string[] aryReplace = new string[] { \"1\", \"2\", \"one\", \"Two\" };");
System.Console.WriteLine();
System.Console.WriteLine("string s = null;");
System.Console.WriteLine(">> s.Replace(aryFind, aryReplace) --> {0}\r\n", s.Replace(aryFind, aryReplace) ?? "null");
s = "One test, two test, 1 test, 2 test";
System.Console.WriteLine("s = \"One test, two test, 1 test, 2 test\";");
System.Console.WriteLine(">> s.Replace(aryFind, aryReplace) --> \"{0}\"\r\n", s.Replace(aryFind, aryReplace));
s = "One test, two test, 1 test, 2 test";
System.Console.WriteLine("s = \"One test, two test, 1 test, 2 test\"; // ignoreCase");
System.Console.WriteLine(">> s.Replace(aryFind, aryReplace, true) --> \"{0}\"\r\n", s.Replace(aryFind, aryReplace, true));
```
Console output will be as follows.
```
string[] aryFind = new string[] { "one", "two", "1", "2" };
string[] aryReplace = new string[] { "1", "2", "one", "Two" };

string s = null;
>> s.Replace(aryFind, aryReplace) --> null

s = "One test, two test, 1 test, 2 test";
>> s.Replace(aryFind, aryReplace) --> "One test, 2 test, one test, Two test"

s = "One test, two test, 1 test, 2 test"; // ignoreCase
>> s.Replace(aryFind, aryReplace, true) --> "1 test, 2 test, one test, Two test"

```

### ToMessages Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Returns all exception messages.
```csharp
public static string ToMessages(this Exception error)
```

#### Parameters
**error**: A parameter of type [System.Exception](https://docs.microsoft.com/en-US/dotnet/api/system.exception).

#### Return
[String](https://docs.microsoft.com/en-US/dotnet/api/system.string) <br>
Returns all messages as string, including internal exceptions.

#### Examples
```csharp
Exception error = new System.IO.FileNotFoundException(
    new System.IO.FileNotFoundException().Message, /* default message */
    new ArgumentNullException(
        new ArgumentNullException("filePath").Message /* default message */,
        new ArgumentException("Invalid file path.")));
Console.WriteLine(">> {0}", error.ToMessages());
```
Console output will be as follows.
```
>> FileNotFoundException: Unable to find the specified file. --> ArgumentNullException: Value cannot be null. Parameter name: filePath --> ArgumentException: Invalid file path.

```

### SafeClone\<T\> Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

It is like the 'Clone' method. It will not throw an exception for an object that is 'null'. <br>
The object must be derived from the [System.ICloneable](https://docs.microsoft.com/en-US/dotnet/api/system.icloneable) interface.
```csharp
public static T SafeClone<T>(this T obj) where T : ICloneable
```

#### Parameters
**obj**: An object of type 'T'.

#### Return
T <br>
'null' or an instance of the object is returned.

### IndexOf\<T\> Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional [IEnumerable](https://docs.microsoft.com/en-US/dotnet/api/system.collections.ienumerable).
```csharp
public static int IndexOf<T>(this System.Collections.IEnumerable source, T item)
```

#### Parameters
**source**: An object of type [System.Collections.IEnumerable](https://docs.microsoft.com/en-US/dotnet/api/system.collections.ienumerable). <br>
**item**: The element in the list whose index number is requested.

#### Return
[Int32](https://docs.microsoft.com/en-US/dotnet/api/system.int32) <br>
The zero-based index of the first occurrence of an element that matches the conditions defined by match, if found; otherwise, -1.

ioCode.Common.Macro
-------------------

A class that outputs strings by compiling specified custom date-time formats.

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

#### Properties
| Name | Type | Description |
| :--- | :--- | :--- |
| **Current** | Macro | A property that presents a public static instance of the current class. |
| **CultureInfo** | [System.Globalization.CultureInfo](https://docs.microsoft.com/en-US/dotnet/api/system.globalization.cultureinfo) | The culture property that will be used for format conversions. |

#### Methods
| Name | Description |
| :--- | :--- |
| **Compile(String, DateTime)** | A method that compiles a string specified with a string parameter and a date-time parameter. <br> - **macroString**: The format string to compile. It is listed in the 'Formats' table. <br> - **dtValue**: The date-time value for the format string to be compiled. |
| **Compile(String)** | A method that compiles a specified string using a string parameter and local date-time information. <br> - **macroString**: The format string to compile. It is listed in the 'Formats' table. |

#### Formats
| Name | Description |
| :--- | :--- |
| **${h}:** | 12-hour clock hour (e.g. 4) |
| **${hh}:** | 12-hour clock, with a leading 0 (e.g. 06) |
| **${H}:** | 24-hour clock hour (e.g. 15) |
| **${HH}:** | 24-hour clock hour, with a leading 0 (e.g. 22) |
| **${m}:** | Minutes |
| **${mm}:** | Minutes with a leading zero |
| **${s}:** | Seconds |
| **${ss}:** | Seconds with a leading zero |
| **${f}:** | Represents the tenths of a second |
| **${ff}:** | Represents the two most significant digits of the seconds' fraction in date and time |
| **${fff}:** | Milliseconds |
| **${t}:** | Abbreviated AM / PM (e.g. A or P) |
| **${tt}:** | AM / PM (e.g. AM or PM) |
| **${d}:** | Represents the day of the month as a number from 1 through 31 |
| **${dd}:** | Represents the day of the month as a number from 01 through 31 |
| **${ddd}:** | Represents the abbreviated name of the day (Mon, Tues, Wed, etc) |
| **${dddd}:** | Represents the full name of the day (Monday, Tuesday, etc) |
| **${wd}:** | Represents the day of the week (e.g. 7 for Sunday) |
| **${M}:** | Month number (eg. 3) |
| **${MM}:** | Month number with leading zero (eg. 04) |
| **${MMM}:** | Abbreviated Month Name (e.g. Dec) |
| **${MMMM}:** | Full month name (e.g. December) |
| **${y}:** | Year, no leading zero (e.g. 2015 would be 15) |
| **${yy}:** | Year, leading zero (e.g. 2015 would be 015) |
| **${yyy}:** | Year, (e.g. 2015) |
| **${yyyy}:** | Year, (e.g. 2015) |
| **${z}:** | With DateTime values represents the signed offset of the local operating system's time zone from Coordinated Universal Time (UTC), measured in hours. (e.g. +6) |
| **${zz}:** | As z, but with leading zero (e.g. +06) |
| **${zzz}:** | With DateTime values represents the signed offset of the local operating system's time zone from UTC, measured in hours and minutes. (e.g. +06:00) |

#### Examples
```csharp
Macro.Current.CultureInfo = System.Globalization.CultureInfo.InvariantCulture;
string s = @".\${yyyy}\${MMMM}\${dddd}\log_${yyyy.MM.dd HH.mm.ss}.log";
Console.WriteLine("Format: \"{0}\"", s);
Console.WriteLine();
Console.WriteLine(">> \"{0}\"", Macro.Current.Compile(s));
Console.WriteLine(">> \"{0}\"", Macro.Current.Compile(s, DateTime.UtcNow));
Console.WriteLine();
Macro.Current.CultureInfo = System.Globalization.CultureInfo.GetCultureInfo("tr-TR");
Console.WriteLine(">> \"{0}\"", Macro.Current.Compile(s));
Console.WriteLine(">> \"{0}\"", Macro.Current.Compile(s, DateTime.UtcNow));
```
Console output will be as follows.
```
Format: ".\${yyyy}\${MMMM}\${dddd}\log_${yyyy.MM.dd HH.mm.ss}.log"

>> ".\2022\May\Thursday\log_2022.05.12 20.24.44.log"
>> ".\2022\May\Thursday\log_2022.05.12 17.24.44.log"

>> ".\2022\Mayis\Persembe\log_2022.05.12 20.24.44.log"
>> ".\2022\Mayis\Persembe\log_2022.05.12 17.24.44.log"

```

ioCode.Common.MathExtensions
----------------------------

It provides extended methods for variables sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long, TimeSpan, DateTime that enforce minimum and maximum range.

### Overload Methods

| Method | Description |
| :--- | :--- |
| [Range(Decimal, Decimal, Decimal)](#rangedecimal-decimal-decimal-method) | Forces the specified decimal value between two limits. |
| [Range(Double, Double, Double)](#rangedouble-double-double-method) | Forces the specified double value between two limits. |
| [Range(Single, Single, Single)](#rangesingle-single-single-method) | Forces the specified float value between two limits. |
| [Range(SByte, SByte, SByte)](#rangesbyte-sbyte-sbyte-method) | Forces the specified sbyte value between two limits. |
| [Range(Int16, Int16, Int16)](#rangeint16-int16-int16-method) | Forces the specified short value between two limits. |
| [Range(Int32, Int32, Int32)](#rangeint32-int32-int32-method) | Forces the specified int value between two limits. |
| [Range(Int64, Int64, Int64)](#rangeint64-int64-int64-method) | Forces the specified long value between two limits. |
| [Range(Byte, Byte, Byte)](#rangebyte-byte-byte-method) | Forces the specified byte value between two limits. |
| [Range(UInt16, UInt16, UInt16)](#rangeuint16-uint16-uint16-method) | Forces the specified ushort value between two limits. |
| [Range(UInt32, UInt32, UInt32)](#rangeuint32-uint32-uint32-method) | Forces the specified uint value between two limits. |
| [Range(UInt64, UInt64, UInt64)](#rangeuint64-uint64-uint64-method) | Forces the specified ulong value between two limits. |
| [Range(TimeSpan, TimeSpan, TimeSpan)](#rangetimespan-timespan-timespan-method) | Forces the specified TimeSpan value between two limits. |
| [Range(DateTime, DateTime, DateTime)](#rangedatetime-datetime-datetime-method) | Forces the specified DateTime value between two limits. |

#### Examples
```csharp
int nVal, nFirst, nLast;
Random rnd = new Random(Environment.TickCount);
for (int i = 0; i < 10; i++)
{
    nVal = (rnd.Next() - (int.MaxValue >> 1)) % 10000;
    nFirst = (rnd.Next() - (int.MaxValue >> 1)) % 10000;
    nLast = (rnd.Next() - (int.MaxValue >> 1)) % 10000;
    Console.WriteLine("({0}).Range({1}, {2}) --> {3}", nVal, nFirst, nLast, nVal.Range(nFirst, nLast));
}
```
Console Output:
```
(8306).Range(3500, -2369) --> 3500
(3024).Range(-2364, 3872) --> 3024
(-6756).Range(1801, -9488) --> -6756
(-4222).Range(-3961, 6258) --> -3961
(7346).Range(2885, -2777) --> 2885
(2705).Range(5300, -250) --> 2705
(-2100).Range(-5751, -8946) --> -5751
(-4440).Range(2352, -9501) --> -4440
(-2876).Range(9931, -1875) --> -1875
(-8038).Range(-6138, -1224) --> -6138
```

### Range(Decimal, Decimal, Decimal) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Decimal](https://docs.microsoft.com/en-US/dotnet/api/system.decimal) value between two limits.
```csharp
public static decimal Range(this decimal n, decimal first, decimal last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Decimal](https://docs.microsoft.com/en-US/dotnet/api/system.decimal) <br>
Returns a value in the specified range.

### Range(Double, Double, Double) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Double](https://docs.microsoft.com/en-US/dotnet/api/system.double) value between two limits.
```csharp
public static double Range(this double n, double first, double last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Double](https://docs.microsoft.com/en-US/dotnet/api/system.double) <br>
Returns a value in the specified range.

### Range(Single, Single, Single) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Single](https://docs.microsoft.com/en-US/dotnet/api/system.single) value between two limits.
```csharp
public static float Range(this float n, float first, float last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Single](https://docs.microsoft.com/en-US/dotnet/api/system.single) <br>
Returns a value in the specified range.

### Range(SByte, SByte, SByte) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.SByte](https://docs.microsoft.com/en-US/dotnet/api/system.sbyte) value between two limits.
```csharp
public static sbyte Range(this sbyte n, sbyte first, sbyte last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[SByte](https://docs.microsoft.com/en-US/dotnet/api/system.sbyte) <br>
Returns a value in the specified range.

### Range(Int16, Int16, Int16) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Int16](https://docs.microsoft.com/en-US/dotnet/api/system.int16) value between two limits.
```csharp
public static short Range(this short n, short first, short last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Int16](https://docs.microsoft.com/en-US/dotnet/api/system.int16) <br>
Returns a value in the specified range.

### Range(Int32, Int32, Int32) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Int32](https://docs.microsoft.com/en-US/dotnet/api/system.int32) value between two limits.
```csharp
public static int Range(this int n, int first, int last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Int32](https://docs.microsoft.com/en-US/dotnet/api/system.int32) <br>
Returns a value in the specified range.

### Range(Int64, Int64, Int64) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Int64](https://docs.microsoft.com/en-US/dotnet/api/system.int64) value between two limits.
```csharp
public static long Range(this long n, long first, long last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Int64](https://docs.microsoft.com/en-US/dotnet/api/system.int64) <br>
Returns a value in the specified range.

### Range(Byte, Byte, Byte) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.Byte](https://docs.microsoft.com/en-US/dotnet/api/system.byte) value between two limits.
```csharp
public static byte Range(this byte n, byte first, byte last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[Byte](https://docs.microsoft.com/en-US/dotnet/api/system.sbyte) <br>
Returns a value in the specified range.

### Range(UInt16, UInt16, UInt16) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.UInt16](https://docs.microsoft.com/en-US/dotnet/api/system.uint16) value between two limits.
```csharp
public static ushort Range(this ushort n, ushort first, ushort last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[UInt16](https://docs.microsoft.com/en-US/dotnet/api/system.uint16) <br>
Returns a value in the specified range.

### Range(UInt32, UInt32, UInt32) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.UInt32](https://docs.microsoft.com/en-US/dotnet/api/system.uint32) value between two limits.
```csharp
public static uint Range(this uint n, uint first, uint last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[UInt32](https://docs.microsoft.com/en-US/dotnet/api/system.uint32) <br>
Returns a value in the specified range.

### Range(UInt64, UInt64, UInt64) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.UInt64](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) value between two limits.
```csharp
public static ulong Range(this ulong n, ulong first, ulong last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[UInt64](https://docs.microsoft.com/en-US/dotnet/api/system.uint64) <br>
Returns a value in the specified range.

### Range(TimeSpan, TimeSpan, TimeSpan) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.TimeSpan](https://docs.microsoft.com/en-US/dotnet/api/system.timespan) value between two limits.
```csharp
public static TimeSpan Range(this TimeSpan n, TimeSpan first, TimeSpan last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[TimeSpan](https://docs.microsoft.com/en-US/dotnet/api/system.timespan) <br>
Returns a value in the specified range.

### Range(DateTime, DateTime, DateTime) Method

#### Definition
Namespace: ioCode.Common  <br>
Assembly: ioCode.Common.dll

Forces the specified [System.DateTime](https://docs.microsoft.com/en-US/dotnet/api/system.datetime) value between two limits.
```csharp
public static DateTime Range(this DateTime n, DateTime first, DateTime last)
```

#### Parameters
**n**: The value to compare with the specified range. <br>
**first**: The first value to compare. <br>
**last**: The last value to compare.

#### Return
[DateTime](https://docs.microsoft.com/en-US/dotnet/api/system.datetime) <br>
Returns a value in the specified range.

Copyright & License
-------------------

Copyright (c) 2022, ioCode

The code is under MIT License. (see [LICENSE](LICENSE))
