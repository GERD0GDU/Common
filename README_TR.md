<p align="center">
  <a href="https://iocode.co.uk/"><img src="assets/logo.png" height=64></a>
</p>

## <div align="center"><b><a href="README.md">English</a> | <a href="README_TR.md">Türkçe</a></b></div>

ioCode.Common C# Kütüphanesi
============================

Dönüşümlerin pratik kullanımı için genişletilmiş yöntemler sağlayan bir kütüphanedir.

**Dikkat** Bu örnek, Microsoft Visual Studio Community 2019 .NET Framework 4.5 veya sonraki bir sürümü (herhangi bir SKU) gerektirir.

Visual Studio'nun bir kopyasını edinmek için şuraya gidin: [Visual Studio Downloads](http://go.microsoft.com/fwlink/p/?linkid=301697).

Sınıflar
--------

[ioCode.Common](https://github.com/GERD0GDU/Common) kütüphanesi aşağıdaki sınıfları içerir.
| Sınıf | Açıklama |
| :--- | :--- |
| [ConversionExtensions](#iocodecommonconversionextensions) | Bir sayının dize temsilini sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long'a dönüştürür. |
| [Extensions](#iocodecommonextensions) | Genel kullanımlar için genişletilmiş yöntemler sağlar. |
| [Macro](#iocodecommonmacro) | Belirtilen özel tarih-saat biçimlerini derleyerek dizeleri çıkaran bir sınıftır. |
| [MathExtensions](#iocodecommonmathextensions) | Minimum ve maksimum aralığı zorlayan sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long, TimeSpan, DateTime değişkenleri için genişletilmiş yöntemler sağlar. |

ioCode.Common.ConversionExtensions
----------------------------------

#### Dikkat

- Dönüştürme işlemleri için kullanılan tüm genişletilmiş yöntemler, herhangi bir hata istisnası döndürmez.
- Bu nedenle yöntemin sonucunun bir garantisi yoktur.
- Dönüştürme başarısız olursa, genişletilmiş yöntem '0' (sıfır) döndürür.
- Dönüştürme başarılı olduğunda, dönüştürülen türün minimum ve maksimum aralığında bir değer döndürür.

### Yöntemler

| Yöntem | Açıklama |
| :--- | :--- |
| [ToDecimal(String, IFormatProvider)](#todecimal-yöntem) | Belirtilen kültüre özgü biçim bilgilerini kullanarak bir sayının dize temsilini System.Decimal eşdeğerine dönüştürür. |
| [ToDecimal(String)](#todecimal-yöntem)  | Bir sayının dize temsilini System.Decimal eşdeğerine dönüştürür. |
| [ToDouble(String, IFormatProvider)](#todouble-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini, çift duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| [ToDouble(String)](#todouble-yöntem) | Bir sayının dize temsilini çift duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| [ToSingle(String, IFormatProvider)](#tosingle-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini tek duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| [ToSingle(String)](#tosingle-yöntem) | Bir sayının dize temsilini tek duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| [ToSByte(String, IFormatProvider)](#tosbyte-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 8 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToSByte(String)](#tosbyte-yöntem) | Bir sayının dize temsilini 8 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt16(String, IFormatProvider)](#toint16-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 16 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt16(String)](#toint16-yöntem) | Bir sayının dize temsilini 16 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt32(String, IFormatProvider)](#toint32-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 32 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt32(String)](#toint32-yöntem) | Bir sayının dize temsilini 32 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt64(String, IFormatProvider)](#toint64-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 64 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToInt64(String)](#toint64-yöntem) | Bir sayının dize temsilini 64 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| [ToByte(String, IFormatProvider)](#tobyte-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 8 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToByte(String)](#tobyte-yöntem) | Bir sayının dize temsilini 8 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt16(String, IFormatProvider)](#touint16-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 16 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt16(String)](#touint16-yöntem) | Bir sayının dize temsilini 16 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt32(String, IFormatProvider)](#touint32-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 32 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt32(String)](#touint32-yöntem) | Bir sayının dize temsilini 32 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt64(String, IFormatProvider)](#touint64-yöntem) | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 64 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToUInt64(String)](#touint64-yöntem) | Bir sayının dize temsilini 64 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| [ToHexString(Byte, String)](#tohexstring-yöntem) | Biçime göre 8 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(Byte)](#tohexstring-yöntem) | 8 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt16, String)](#tohexstring-yöntem) | Biçime göre 16 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt16)](#tohexstring-yöntem) | 16 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt32, String)](#tohexstring-yöntem) | Biçime göre 32 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt32)](#tohexstring-yöntem) | 32 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt64, String)](#tohexstring-yöntem) | Biçime göre 64 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| [ToHexString(UInt64)](#tohexstring-yöntem) | 64 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |

### ToDecimal Yöntem

#### Tanım
Ad Alanı: ioCode.Common <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToDecimal(String, IFormatProvider)** | Belirtilen kültüre özgü biçim bilgilerini kullanarak bir sayının dize temsilini System.Decimal eşdeğerine dönüştürür. |
| **ToDecimal(String)** | Bir sayının dize temsilini System.Decimal eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Decimal](https://docs.microsoft.com/tr-TR/dotnet/api/system.decimal) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Decimal](https://docs.microsoft.com/tr-TR/dotnet/api/system.decimal) sayı.

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
"1.9876E+9" --> 1987600000
"79228162514264337593543950334" --> 79228162514264337593543950334
"0x123456789ABCDEF0" --> 1311768467463790320 (0x123456789ABCDEF0)
"&H9ABCDEF012345678" --> 11150031900141442680 (0x9ABCDEF012345678)
```

### ToDouble Yöntem

#### Tanım
Ad Alanı: ioCode.Common <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToDouble(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini, çift duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| **ToDouble(String)** | Bir sayının dize temsilini çift duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Double](https://docs.microsoft.com/tr-TR/dotnet/api/system.double) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Double](https://docs.microsoft.com/tr-TR/dotnet/api/system.double) sayı.

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
"1.9876E+9" --> 1987600000
"79228162514264337593543950334" --> 7.92281625142643E+28
"0x123456789ABCDEF0" --> 1.31176846746379E+18 (0x123456789ABCDF00)
"&H9ABCDEF012345678" --> 1.11500319001414E+19 (0x9ABCDEF012345800)
```

### ToSingle Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToSingle(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini tek duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |
| **ToSingle(String)** | Bir sayının dize temsilini tek duyarlıklı kayan noktalı sayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Single](https://docs.microsoft.com/tr-TR/dotnet/api/system.single) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Single](https://docs.microsoft.com/tr-TR/dotnet/api/system.single) sayı.

### ToSByte Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToSByte(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 8 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| **ToSByte(String)** | Bir sayının dize temsilini 8 bitlik işaretli tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[SByte](https://docs.microsoft.com/tr-TR/dotnet/api/system.sbyte) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.SByte](https://docs.microsoft.com/tr-TR/dotnet/api/system.sbyte) sayı.

### ToInt16 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToInt16(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 16 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| **ToInt16(String)** | Bir sayının dize temsilini 16 bitlik işaretli tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Int16](https://docs.microsoft.com/tr-TR/dotnet/api/system.int16) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Int16](https://docs.microsoft.com/tr-TR/dotnet/api/system.int16) sayı.

### ToInt32 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToInt32(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 32 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| **ToInt32(String)** | Bir sayının dize temsilini 32 bitlik işaretli tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Int32](https://docs.microsoft.com/tr-TR/dotnet/api/system.int32) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Int32](https://docs.microsoft.com/tr-TR/dotnet/api/system.int32) sayı.

### ToInt64 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToInt64(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 64 bitlik işaretli tamsayı eşdeğerine dönüştürür. |
| **ToInt64(String)** | Bir sayının dize temsilini 64 bitlik işaretli tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Int64](https://docs.microsoft.com/tr-TR/dotnet/api/system.int64) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Int64](https://docs.microsoft.com/tr-TR/dotnet/api/system.int64) sayı.

### ToByte Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToByte(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 8 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| **ToByte(String)** | Bir sayının dize temsilini 8 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[Byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.byte) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.Byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.byte) sayı.

### ToUInt16 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToUInt16(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 16 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| **ToUInt16(String)** | Bir sayının dize temsilini 16 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[UInt16](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.UInt16](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16) sayı.

### ToUInt32 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToUInt32(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 32 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| **ToUInt32(String)** | Bir sayının dize temsilini 32 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[UInt32](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint32) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.UInt32](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint32) sayı.

### ToUInt64 Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToUInt64(String, IFormatProvider)** | Belirli bir kültüre özgü biçimde bir sayının dize temsilini 64 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |
| **ToUInt64(String)** | Bir sayının dize temsilini 64 bitlik işaretsiz tamsayı eşdeğerine dönüştürür. |

#### Parametreler
**s**: Dönüştürülecek sayının [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) tipinden dize temsilidir. <br>
**provider**: **'s'** hakkında kültüre özgü ayrıştırma bilgileri sağlayan bir [System.IFormatProvider](https://docs.microsoft.com/tr-TR/dotnet/api/system.iformatprovider) tipinde bir nesnedir.

#### Dönüş
[UInt64](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) <br>
Sağlayıcı tarafından belirtildiği şekilde s içinde yer alan sayıya eşdeğer [System.UInt64](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) sayı.

### ToHexString Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

[byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.byte), [ushort](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16), [uint](https://docs.microsoft.com/tr-TR/dotnet/api/system.uin32) or [ulong](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) türlerini onaltılık dizelere dönüştüren genişletilmiş yöntem.

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **ToHexString(Byte, String)** | Biçime göre 8 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(Byte)** | 8 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt16, String)** | Biçime göre 16 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt16)** | 16 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt32, String)** | Biçime göre 32 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt32)** | 32 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt64, String)** | Biçime göre 64 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |
| **ToHexString(UInt64)** | 64 bitlik işaretsiz bir tamsayıyı onaltılık bir dizeye dönüştürür. |

#### Parametreler
**n**: Dönüştürülecek sayıyı temsil eden bir [byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.byte), [ushort](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16), [uint](https://docs.microsoft.com/tr-TR/dotnet/api/system.uin32) or [ulong](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64). <br>
**format**: "0" veya "H" şeklinde bir [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) değeri belirtilebilir.

#### Dönüş
[String](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) <br>
Biçim değerine göre onaltılık bir [string](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) değeri döndürür.

#### Örnekler
```csharp
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString() --> {0}", (ulong.MaxValue >> 9).ToHexString());
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString(\"0\") --> {0}", (ulong.MaxValue >> 9).ToHexString("0"));
System.Console.WriteLine("(ulong.MaxValue >> 9).ToHexString(\"H\") --> {0}", (ulong.MaxValue >> 9).ToHexString("H"));
```
Konsol çıktısı aşağıdaki gibi olacaktır.
```
(ulong.MaxValue >> 9).ToHexString() --> 7FFFFFFFFFFFFF
(ulong.MaxValue >> 9).ToHexString("0") --> 0x007FFFFFFFFFFFFF
(ulong.MaxValue >> 9).ToHexString("H") --> &H007FFFFFFFFFFFFF
```

ioCode.Common.Extensions
------------------------

Genel kullanımlar için genişletilmiş yöntemler sağlar.

| Yöntem | Açıklama |
| :--- | :--- |
| [IsNull\<T\>(T)](#isnullt-yöntem) | Herhangi bir nesnenin tanımsız olup olmadığını test eder. "obj is null" ile aynıdır. |
| [IsNotNull\<T\>(T)](#isnotnullt-yöntem) | Herhangi bir nesnenin tanımlı olup olmadığını test eder. "!(obj is null)" ile aynıdır. |
| [IsNullOrEmpty(IEnumerable)](#isnullorempty-yöntem) | "[System.Collections.IEnumerable](https://docs.microsoft.com/tr-TR/dotnet/api/system.collections.ienumerable)" arabiriminden türetilen herhangi bir nesnenin boş olup olmadığını test eder. |
| [ToSafeString(Object)](#tosafestring-yöntem) | ToString() gibidir, ancak nesne tanımsız olsa bile herhangi bir hata oluşturmaz. |
| [Left(String, Int32)](#left-yöntem) | Dizenin solundan itibaren belirtilen uzunlukta bir dize döndürür. "[System.String.Substring](https://docs.microsoft.com/tr-TR/dotnet/api/system.string.substring)" kullanımı gibidir ancak herhangi bir hata döndürmez. |
| [Right(String, Int32)](#right-yöntem) | Dizenin sağından belirtilen uzunlukta bir dize döndürür. |
| [Mid(String, Int32, Int32)](#mid-yöntem) | Bu örnekten bir alt dize alır. Alt dize, belirli bir karakter konumunda başlar ve belirli bir uzunluğa sahiptir. |
| [RemoveNewLines(String)](#removenewlines-yöntem) | Dizedeki '\r\n' karakterlerini boşluklarla değiştirir. |
| [Replace(String, String[], String[], StringComparison)](#replace-yöntem) | Değiştirme işlemleri için bir karşılaştırma seçeneği sunulur. |
| [Replace(String, String[], String[], bool)](#replace-yöntem) | Değiştirme işlemleri için büyük/küçük harf duyarlılığı seçeneği sağlanır. |
| [Replace(String, String[], String[])](#replace-yöntem) | Büyük/küçük harfe duyarlı bir değiştirme yapar. |
| [ToMessages(Exception)](#tomessages-yöntem) | Dahili istisnalar dahil tüm hata mesajlarını döndürür. |
| [SafeClone\<T\>(T)](#safeclonet-yöntem) | 'Clone' yöntemi gibidir. 'Tanımsız' olan bir nesne için bir hata döndürmez. |
| [IndexOf\<T\>(IEnumerable, T)](#indexoft-yöntem) | Belirtilen nesneyi arar ve tek boyutlu [IEnumerable](https://docs.microsoft.com/tr-TR/dotnet/api/system.collections.ienumerable) içindeki ilk öğenin sıra numarasını döndürür. |

### IsNull\<T\> Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Herhangi bir nesnenin tanımsız olup olmadığını test eder. "obj is null" ile aynıdır.
```csharp
public static bool IsNull<T>(this T obj) where T : class
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.IsNull() --> True

s = "";
>> s.IsNull() --> False

s = "blabla";
>> s.IsNull() --> False

```

### IsNotNull\<T\> Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Herhangi bir nesnenin tanımlı olup olmadığını test eder. "!(obj is null)" ile aynıdır.
```csharp
public static bool IsNotNull<T>(this T obj) where T : class
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.IsNotNull() --> False

s = "";
>> s.IsNotNull() --> True

s = "blabla";
>> s.IsNotNull() --> True

```

### IsNullOrEmpty Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

"[System.Collections.IEnumerable](https://docs.microsoft.com/tr-TR/dotnet/api/system.collections.ienumerable)" arabiriminden türetilen herhangi bir nesnenin boş olup olmadığını test eder.
```csharp
public static bool IsNullOrEmpty(this System.Collections.IEnumerable items)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
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

### ToSafeString Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

ToString() gibidir, ancak nesne tanımsız olsa bile herhangi bir hata oluşturmaz.
```csharp
public static string ToSafeString(this object obj)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.ToSafeString() --> null

s = "";
>> s.ToSafeString() --> ""

s = "blabla";
>> s.ToSafeString() --> "blabla"

```

### Left Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Dizenin solundan itibaren belirtilen uzunlukta bir dize döndürür. "[System.String.Substring](https://docs.microsoft.com/tr-TR/dotnet/api/system.string.substring)" kullanımı gibidir ancak herhangi bir hata döndürmez.
```csharp
public static string Left(this string s, int length)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.Left(3) --> null

s = "";
>> s.Left(3) --> ""

s = "blabla";
>> s.Left(3) --> "bla"

```

### Right Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Dizenin sağından belirtilen uzunlukta bir dize döndürür.
```csharp
public static string Right(this string s, int length)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.Right(3) --> null

s = "";
>> s.Right(3) --> ""

s = "abcdefg";
>> s.Right(3) --> "efg"

```

### Mid Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Bu örnekten bir alt dize alır. Alt dize, belirli bir karakter konumunda başlar ve belirli bir uzunluğa sahiptir.
```csharp
public static string Mid(this string s, int startIndex, int length)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
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

### RemoveNewLines Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Dizedeki '\r\n' karakterlerini boşluklarla değiştirir.
```csharp
public static string RemoveNewLines(this string s)
```

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
string s = null;
>> s.RemoveNewLines() --> null

s = "";
>> s.RemoveNewLines() --> ""

s = "abc\rdefg\n1234\r\n5678";
>> s.RemoveNewLines() --> "abc defg 1234 5678"

```

### Replace Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Geçerli örnekte belirtilen bir dizenin tüm metinlerini belirtilen başka bir dizenin metinleriyle değiştirerek yeni bir dize döndürür. <br>
Bu yöntem, aynı anda birden çok metni değiştirir.

#### Aşırı Yüklemeler
| Yöntem | Açıklama |
| :--- | :--- |
| **Replace(String, String[], String[], StringComparison)** | Değiştirme işlemleri için bir karşılaştırma seçeneği sunulur. |
| **Replace(String, String[], String[], bool)** | Değiştirme işlemleri için büyük/küçük harf duyarlılığı seçeneği sağlanır. |
| **Replace(String, String[], String[])** | Büyük/küçük harfe duyarlı bir değiştirme yapar. |

#### Parametreler
| Name | Type | Description |
| :--- | :--- | :--- |
| **s** | [String](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) | Değiştirilecek dize. |
| **oldValues** | String[] | Değiştirilecek metin dizisi. |
| **newValues** | String[] | Tüm oldValues oluşumlarını değiştirecek metin dizesi. |
| **comparisonType** | [StringComparison](https://docs.microsoft.com/tr-TR/dotnet/api/system.stringcomparison) | Bu dize ve değerin nasıl karşılaştırılacağını belirleyen seçenek değerlerinden biri. |
| **ignoreCase** | [Boolean](https://docs.microsoft.com/tr-TR/dotnet/api/system.boolean) | Karşılaştırma sırasında büyük/küçük harfi yok saymak için 'true' ; aksi halde 'false'. |

#### Dönüş
[String](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) <br>
Dize türü olarak değiştirilen dizenin bir örneğini döndürür.

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
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

### ToMessages Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Tüm hata mesajlarını döndürür.
```csharp
public static string ToMessages(this Exception error)
```

#### Parametreler
**error**: [System.Exception](https://docs.microsoft.com/tr-TR/dotnet/api/system.exception) tipinden bir parametre.

#### Dönüş
[String](https://docs.microsoft.com/tr-TR/dotnet/api/system.string) <br>
Dahili istisnalar dahil tüm iletileri dize olarak döndürür.

#### Örnekler
```csharp
Exception error = new System.IO.FileNotFoundException(
    new System.IO.FileNotFoundException().Message, /* default message */
    new ArgumentNullException(
        new ArgumentNullException("filePath").Message /* default message */,
        new ArgumentException("Invalid file path.")));
Console.WriteLine(">> {0}", error.ToMessages());
```
Konsol çıktısı aşağıdaki gibi olacaktır.
```
>> FileNotFoundException: Unable to find the specified file. --> ArgumentNullException: Value cannot be null. Parameter name: filePath --> ArgumentException: Invalid file path.

```

### SafeClone\<T\> Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

'Clone' yöntemi gibidir. 'Tanımsız' olan bir nesne için bir hata döndürmez. <br>
Bu yönteme başvuracak nesne, [System.ICloneable](https://docs.microsoft.com/tr-TR/dotnet/api/system.icloneable) arayüzünden türetilmelidir.
```csharp
public static T SafeClone<T>(this T obj) where T : ICloneable
```

#### Parametreler
**obj**: 'T' tipinden bir nesne.

#### Dönüş
T <br>
'null' veya nesnenin bir örneği döndürülür.

### IndexOf\<T\> Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen nesneyi arar ve tek boyutlu [IEnumerable](https://docs.microsoft.com/tr-TR/dotnet/api/system.collections.ienumerable) içindeki ilk öğenin sıra numarasını döndürür.
```csharp
public static int IndexOf<T>(this System.Collections.IEnumerable source, T item)
```

#### Parametreler
**source**: [System.Collections.IEnumerable](https://docs.microsoft.com/tr-TR/dotnet/api/system.collections.ienumerable) tipinden bir nesne. <br>
**item**: Sıra numarası istenen listedeki eleman.

#### Dönüş
[Int32](https://docs.microsoft.com/tr-TR/dotnet/api/system.int32) <br>
Bulunursa, eşleşen ilk öğenin sıfır tabanlı sıra numarasını; aksi halde, –1 döndürür.

ioCode.Common.Macro
-------------------

Belirtilen özel tarih-saat biçimlerini derleyerek metin tipinde çıktı veren bir sınıf.

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

#### Properties
| Name | Type | Description |
| :--- | :--- | :--- |
| **Current** | Macro | Geçerli sınıfın genel statik örneğini sunan bir özellik. |
| **CultureInfo** | [System.Globalization.CultureInfo](https://docs.microsoft.com/tr-TR/dotnet/api/system.globalization.cultureinfo) | Biçim dönüştürmeleri için kullanılacak kültür özelliği. |

#### Yöntemler
| Name | Description |
| :--- | :--- |
| **Compile(String, DateTime)** | Bir metin biçim parametresi ve bir tarih-saat parametresiyle belirtilen bir metni derleyen bir yöntem. <br> - **macroString**: Derlenecek biçim dizesi. 'Biçimler' tablosunda listelenir. <br> - **dtValue**: Derlenecek biçim dizesi için tarih-zaman değeri. |
| **Compile(String)** | Bir metin biçim parametresi ve bir tarih-saat parametresiyle belirtilen bir metni derleyen bir yöntem. <br> - **macroString**: Derlenecek biçim dizesi. 'Biçimler' tablosunda listelenir. |

#### Biçimler
| Name | Description |
| :--- | :--- |
| **${h}:** | 12 saatlik saat hanesi (ör. 4) |
| **${hh}:** | Başında 0 olan 12 saatlik saat hanesi (ör. 06) |
| **${H}:** | 24 saatlik saat hanesi (ör. 15) |
| **${HH}:** | 24 saatlik saat hanesi, başta 0 olmak üzere (ör. 22) |
| **${m}:** | Dakika hanesi |
| **${mm}:** | Dakika hanesi, başta 0 olmak üzere |
| **${s}:** | Saniye hanesi |
| **${ss}:** | Saniye hanesi, başta 0 olmak üzere |
| **${f}:** | Saniyenin onda birini temsil eder |
| **${ff}:** | Tarih ve saatteki saniye kesrinin en önemli iki basamağını temsil eder |
| **${fff}:** | Milisaniye hanesi |
| **${t}:** | Kısaltılmış AM / PM (ör. A veya P) |
| **${tt}:** | AM / PM (ör. AM veya PM) |
| **${d}:** | 1'den 31'e kadar bir sayı olarak ayın gününü temsil eder |
| **${dd}:** | 01'den 31'e kadar bir sayı olarak ayın gününü temsil eder |
| **${ddd}:** | Günün kısaltılmış adını temsil eder (Pzt, Salı, Çar, vb.) |
| **${dddd}:** | Günün tam adını temsil eder (Pazartesi, Salı vb.) |
| **${wd}:** | Haftanın gününü temsil eder (ör. Pazar için 7) |
| **${M}:** | Ay numarası (örn. 3) |
| **${MM}:** | Başında sıfır olan ay numarası (örn. 04) |
| **${MMM}:** | Kısaltılmış Ay Adı (ör. Ara) |
| **${MMMM}:** | Tam ay adı (ör. Aralık) |
| **${y}:** | Yıl, başında sıfır yok (ör. 2015 15 olur) |
| **${yy}:** | Yıl, baştaki sıfır (ör. 2015, 015 olur) |
| **${yyy}:** | Yıl, (ör. 2015) |
| **${yyyy}:** | Yıl, (ör. 2015) |
| **${z}:** | DateTime ile değerler, yerel işletim sisteminin saat diliminin Eşgüdümlü Evrensel Saat'ten (UTC) saat cinsinden ölçülen işaretli uzaklığını temsil eder. (ör. +6) |
| **${zz}:** | 'z' gibidir, ancak başında sıfır olacak şekilde (ör. +06) |
| **${zzz}:** | DateTime ile değerler, yerel işletim sisteminin saat diliminin UTC'den saat ve dakika olarak ölçülen işaretli ofsetini temsil eder. (ör. +06:00) |

#### Örnekler
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
Konsol çıktısı aşağıdaki gibi olacaktır.
```
Format: ".\${yyyy}\${MMMM}\${dddd}\log_${yyyy.MM.dd HH.mm.ss}.log"

>> ".\2022\May\Thursday\log_2022.05.12 20.24.44.log"
>> ".\2022\May\Thursday\log_2022.05.12 17.24.44.log"

>> ".\2022\Mayis\Persembe\log_2022.05.12 20.24.44.log"
>> ".\2022\Mayis\Persembe\log_2022.05.12 17.24.44.log"

```

ioCode.Common.MathExtensions
----------------------------

Minimum ve maksimum aralığı zorlayan sbyte, short, int, long, decimal, double, float, byte, ushort, uint, long, TimeSpan, DateTime değişkenleri için genişletilmiş yöntemler sağlar.

### Overload Methods

| Yöntem | Açıklama |
| :--- | :--- |
| [Range(Decimal, Decimal, Decimal)](#rangedecimal-decimal-decimal-yöntem) | Belirtilen 'decimal' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Double, Double, Double)](#rangedouble-double-double-yöntem) | Belirtilen 'double' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Single, Single, Single)](#rangesingle-single-single-yöntem) | Belirtilen 'float' cinsinden değeri iki sınır arasında zorlar. |
| [Range(SByte, SByte, SByte)](#rangesbyte-sbyte-sbyte-yöntem) | Belirtilen 'sbyte' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Int16, Int16, Int16)](#rangeint16-int16-int16-yöntem) | Belirtilen 'short' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Int32, Int32, Int32)](#rangeint32-int32-int32-yöntem) | Belirtilen 'int' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Int64, Int64, Int64)](#rangeint64-int64-int64-yöntem) | Belirtilen 'long' cinsinden değeri iki sınır arasında zorlar. |
| [Range(Byte, Byte, Byte)](#rangebyte-byte-byte-yöntem) | Belirtilen 'byte' cinsinden değeri iki sınır arasında zorlar. |
| [Range(UInt16, UInt16, UInt16)](#rangeuint16-uint16-uint16-yöntem) | Belirtilen 'ushort' cinsinden değeri iki sınır arasında zorlar. |
| [Range(UInt32, UInt32, UInt32)](#rangeuint32-uint32-uint32-yöntem) | Belirtilen 'uint' cinsinden değeri iki sınır arasında zorlar. |
| [Range(UInt64, UInt64, UInt64)](#rangeuint64-uint64-uint64-yöntem) | Belirtilen 'ulong' cinsinden değeri iki sınır arasında zorlar. |
| [Range(TimeSpan, TimeSpan, TimeSpan)](#rangetimespan-timespan-timespan-yöntem) | Belirtilen 'TimeSpan' cinsinden değeri iki sınır arasında zorlar. |
| [Range(DateTime, DateTime, DateTime)](#rangedatetime-datetime-datetime-yöntem) | Belirtilen 'DateTime' cinsinden değeri iki sınır arasında zorlar. |

#### Örnekler
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

### Range(Decimal, Decimal, Decimal) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Decimal](https://docs.microsoft.com/tr-TR/dotnet/api/system.decimal) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static decimal Range(this decimal n, decimal first, decimal last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Decimal](https://docs.microsoft.com/tr-TR/dotnet/api/system.decimal) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Double, Double, Double) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Double](https://docs.microsoft.com/tr-TR/dotnet/api/system.double) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static double Range(this double n, double first, double last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Double](https://docs.microsoft.com/tr-TR/dotnet/api/system.double) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Single, Single, Single) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Single](https://docs.microsoft.com/tr-TR/dotnet/api/system.single) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static float Range(this float n, float first, float last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Single](https://docs.microsoft.com/tr-TR/dotnet/api/system.single) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(SByte, SByte, SByte) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.SByte](https://docs.microsoft.com/tr-TR/dotnet/api/system.sbyte) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static sbyte Range(this sbyte n, sbyte first, sbyte last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[SByte](https://docs.microsoft.com/tr-TR/dotnet/api/system.sbyte) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Int16, Int16, Int16) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Int16](https://docs.microsoft.com/tr-TR/dotnet/api/system.int16) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static short Range(this short n, short first, short last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Int16](https://docs.microsoft.com/tr-TR/dotnet/api/system.int16) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Int32, Int32, Int32) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Int32](https://docs.microsoft.com/tr-TR/dotnet/api/system.int32) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static int Range(this int n, int first, int last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Int32](https://docs.microsoft.com/tr-TR/dotnet/api/system.int32) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Int64, Int64, Int64) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Int64](https://docs.microsoft.com/tr-TR/dotnet/api/system.int64) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static long Range(this long n, long first, long last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Int64](https://docs.microsoft.com/tr-TR/dotnet/api/system.int64) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(Byte, Byte, Byte) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.Byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.byte) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static byte Range(this byte n, byte first, byte last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[Byte](https://docs.microsoft.com/tr-TR/dotnet/api/system.sbyte) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(UInt16, UInt16, UInt16) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.UInt16](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static ushort Range(this ushort n, ushort first, ushort last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[UInt16](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint16) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(UInt32, UInt32, UInt32) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.UInt32](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint32) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static uint Range(this uint n, uint first, uint last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[UInt32](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint32) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(UInt64, UInt64, UInt64) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.UInt64](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static ulong Range(this ulong n, ulong first, ulong last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[UInt64](https://docs.microsoft.com/tr-TR/dotnet/api/system.uint64) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(TimeSpan, TimeSpan, TimeSpan) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.TimeSpan](https://docs.microsoft.com/tr-TR/dotnet/api/system.timespan) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static TimeSpan Range(this TimeSpan n, TimeSpan first, TimeSpan last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[TimeSpan](https://docs.microsoft.com/tr-TR/dotnet/api/system.timespan) <br>
Belirtilen aralıkta bir değer döndürür.

### Range(DateTime, DateTime, DateTime) Yöntem

#### Tanım
Ad Alanı: ioCode.Common  <br>
Bütünleştirilmiş Kod: ioCode.Common.dll

Belirtilen [System.DateTime](https://docs.microsoft.com/tr-TR/dotnet/api/system.datetime) cinsinden değeri iki sınır arasında zorlar.
```csharp
public static DateTime Range(this DateTime n, DateTime first, DateTime last)
```

#### Parametreler
**n**: Belirtilen aralıkla karşılaştırılacak değer. <br>
**first**: Karşılaştırılacak ilk değer. <br>
**last**: Karşılaştırılacak ikinci değer.

#### Dönüş
[DateTime](https://docs.microsoft.com/tr-TR/dotnet/api/system.datetime) <br>
Belirtilen aralıkta bir değer döndürür.

Telif Hakkı ve Lisans
---------------------

Telif hakkı (c) 2022, ioCode

Paylaşılan kodlar MIT Lisansı ile korunmaktadır. (bkz. [LICENSE](LICENSE))
