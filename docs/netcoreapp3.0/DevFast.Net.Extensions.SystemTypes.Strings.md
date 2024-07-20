#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.SystemTypes](DevFast.Net.Extensions.SystemTypes.md 'DevFast.Net.Extensions.SystemTypes')

## Strings Class

Extension methods on [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

```csharp
public static class Strings
```
- *Methods*
  - **[IsNotNows(this string)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(thisstring) 'DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(this string)')**
  - **[IsNows(this string)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.IsNows(thisstring) 'DevFast.Net.Extensions.SystemTypes.Strings.IsNows(this string)')**
  - **[TrimSafeAndLower(this string, string, CultureInfo)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo) 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(this string, string, System.Globalization.CultureInfo)')**
  - **[TrimSafeAndUpper(this string, string, CultureInfo)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo) 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(this string, string, System.Globalization.CultureInfo)')**
  - **[TrimSafeOrDefault(this string, string, char[])](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[]) 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(this string, string, char[])')**
  - **[TrimSafeOrEmpty(this string, char[])](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrEmpty(thisstring,char[]) 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrEmpty(this string, char[])')**
  - **[TrimSafeOrNull(this string, char[])](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrNull(thisstring,char[]) 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrNull(this string, char[])')**
  - **[TryTo(this string, bool)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,bool) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, bool)')**
  - **[TryTo(this string, byte, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, byte, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, decimal, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, decimal, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, double, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, double, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, float, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, float, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, int, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, int, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, long, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, long, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, sbyte, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, sbyte, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, short, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, short, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, DateTime, string, DateTimeStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, System.DateTime, string, System.Globalization.DateTimeStyles, System.IFormatProvider)')**
  - **[TryTo(this string, DateTime, string[], DateTimeStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, System.DateTime, string[], System.Globalization.DateTimeStyles, System.IFormatProvider)')**
  - **[TryTo(this string, DateTime, DateTimeStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, System.DateTime, System.Globalization.DateTimeStyles, System.IFormatProvider)')**
  - **[TryTo(this string, Guid)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.Guid) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, System.Guid)')**
  - **[TryTo(this string, uint, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, uint, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, ulong, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, ulong, System.Globalization.NumberStyles, System.IFormatProvider)')**
  - **[TryTo(this string, ushort, NumberStyles, IFormatProvider)](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider) 'DevFast.Net.Extensions.SystemTypes.Strings.TryTo(this string, ushort, System.Globalization.NumberStyles, System.IFormatProvider)')**

## Strings Class

Extension methods on [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

```csharp
public static class Strings
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Strings
### Methods

<a name='DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(thisstring)'></a>

## Strings.IsNotNows(this string) Method

Checks whether [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(thisstring).input 'DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(this string).input') is NOT NullOrWhiteSpace string.

```csharp
public static bool IsNotNows(this string? input);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.IsNotNows(thisstring).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to check

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.IsNows(thisstring)'></a>

## Strings.IsNows(this string) Method

Checks whether [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.IsNows(thisstring).input 'DevFast.Net.Extensions.SystemTypes.Strings.IsNows(this string).input') is NullOrWhiteSpace string.

```csharp
public static bool IsNows(this string? input);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.IsNows(thisstring).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to check

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo)'></a>

## Strings.TrimSafeAndLower(this string, string, CultureInfo) Method

Trims and converts the [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).input 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(this string, string, System.Globalization.CultureInfo).input') string based on given culture
(if not supplied then <seealso cref="P:System.Globalization.CultureInfo.InvariantCulture"/> is used).
If [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).input 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(this string, string, System.Globalization.CultureInfo).input') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), returns the provided
[defaultValue](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).defaultValue 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(this string, string, System.Globalization.CultureInfo).defaultValue') (without trimming and case-conversion!).

```csharp
public static string TrimSafeAndLower(this string? input, string defaultValue="", System.Globalization.CultureInfo? culture=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

value to operate on

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).defaultValue'></a>

`defaultValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

return value in case, supplied value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndLower(thisstring,string,System.Globalization.CultureInfo).culture'></a>

`culture` [System.Globalization.CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.CultureInfo 'System.Globalization.CultureInfo')

Culture to use, if [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') or not supplied, then <seealso cref="P:System.Globalization.CultureInfo.InvariantCulture"/> is used.

### See Also
- [System.Globalization.CultureInfo.InvariantCulture](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.CultureInfo.InvariantCulture 'System.Globalization.CultureInfo.InvariantCulture')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo)'></a>

## Strings.TrimSafeAndUpper(this string, string, CultureInfo) Method

Trims and converts the [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).input 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(this string, string, System.Globalization.CultureInfo).input') string based on given culture
(if not supplied then <seealso cref="P:System.Globalization.CultureInfo.InvariantCulture"/> is used).
If [input](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).input 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(this string, string, System.Globalization.CultureInfo).input') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), returns the provided
[defaultValue](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).defaultValue 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(this string, string, System.Globalization.CultureInfo).defaultValue') (without trimming and case-conversion!).

```csharp
public static string TrimSafeAndUpper(this string? input, string defaultValue="", System.Globalization.CultureInfo? culture=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

value to operate on

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).defaultValue'></a>

`defaultValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

return value in case, supplied value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeAndUpper(thisstring,string,System.Globalization.CultureInfo).culture'></a>

`culture` [System.Globalization.CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.CultureInfo 'System.Globalization.CultureInfo')

Culture to use, if null or not supplied, then <seealso cref="P:System.Globalization.CultureInfo.InvariantCulture"/> is used.

### See Also
- [System.Globalization.CultureInfo.InvariantCulture](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.CultureInfo.InvariantCulture 'System.Globalization.CultureInfo.InvariantCulture')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[])'></a>

## Strings.TrimSafeOrDefault(this string, string, char[]) Method

If value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), provided [defaultValue](DevFast.Net.Extensions.SystemTypes.Strings.md#DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[]).defaultValue 'DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(this string, string, char[]).defaultValue') is returned;
otherwise trimmed string is returned.

```csharp
public static string? TrimSafeOrDefault(this string? input, string? defaultValue, params char[]? trimChars);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[]).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Value to trim safe

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[]).defaultValue'></a>

`defaultValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

default value to return when input is null.

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrDefault(thisstring,string,char[]).trimChars'></a>

`trimChars` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

optional. when not given any char set,
            whitespaces will be removed

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrEmpty(thisstring,char[])'></a>

## Strings.TrimSafeOrEmpty(this string, char[]) Method

If value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), <seealso cref="F:System.String.Empty"/> is returned;
otherwise trimmed string is returned.

```csharp
public static string TrimSafeOrEmpty(this string? input, params char[]? trimChars);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrEmpty(thisstring,char[]).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Value to trim safe

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrEmpty(thisstring,char[]).trimChars'></a>

`trimChars` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

optional. when not given any char set,
            whitespaces will be removed

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrNull(thisstring,char[])'></a>

## Strings.TrimSafeOrNull(this string, char[]) Method

If value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') is returned;
otherwise trimmed string is returned.

```csharp
public static string? TrimSafeOrNull(this string? input, params char[]? trimChars);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrNull(thisstring,char[]).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Value to trim safe

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TrimSafeOrNull(thisstring,char[]).trimChars'></a>

`trimChars` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

optional. when not given any char set,
            whitespaces will be removed

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,bool)'></a>

## Strings.TryTo(this string, bool) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Boolean"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out bool value);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,bool).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,bool).value'></a>

`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

parsed value

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, byte, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Byte"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out byte value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,byte,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, decimal, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Decimal"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out decimal value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,decimal,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, double, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Double"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out double value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,double,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, float, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Single"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out float value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,float,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, int, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Int32"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out int value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,int,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, long, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Int64"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out long value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,long,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, sbyte, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.SByte"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out sbyte value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,sbyte,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, short, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Int16"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out short value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,short,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, DateTime, string, DateTimeStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.DateTime"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out System.DateTime value, string format, System.Globalization.DateTimeStyles style=System.Globalization.DateTimeStyles.None, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider).value'></a>

`value` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

DateTime format to use.

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.DateTimeStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.DateTimeStyles 'System.Globalization.DateTimeStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string,System.Globalization.DateTimeStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, DateTime, string[], DateTimeStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.DateTime"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out System.DateTime value, string[] formats, System.Globalization.DateTimeStyles style=System.Globalization.DateTimeStyles.None, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider).value'></a>

`value` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider).formats'></a>

`formats` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

DateTime formats to use.

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.DateTimeStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.DateTimeStyles 'System.Globalization.DateTimeStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,string[],System.Globalization.DateTimeStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, DateTime, DateTimeStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.DateTime"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out System.DateTime value, System.Globalization.DateTimeStyles style=System.Globalization.DateTimeStyles.None, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider).value'></a>

`value` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.DateTimeStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.DateTimeStyles 'System.Globalization.DateTimeStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.DateTime,System.Globalization.DateTimeStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.Guid)'></a>

## Strings.TryTo(this string, Guid) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.Guid"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out System.Guid value);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.Guid).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,System.Guid).value'></a>

`value` [System.Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid 'System.Guid')

parsed value

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, uint, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.UInt32"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out uint value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,uint,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, ulong, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.UInt64"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out ulong value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ulong,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider)'></a>

## Strings.TryTo(this string, ushort, NumberStyles, IFormatProvider) Method

Tries parsing <seealso cref="T:System.String"/> to <seealso cref="T:System.UInt16"/> value.
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if parsing is successful else [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public static bool TryTo(this string? input, out ushort value, System.Globalization.NumberStyles style=System.Globalization.NumberStyles.Any, System.IFormatProvider? formatProvider=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string to parse

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

parsed value

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider).style'></a>

`style` [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles')

style to use during parsing

<a name='DevFast.Net.Extensions.SystemTypes.Strings.TryTo(thisstring,ushort,System.Globalization.NumberStyles,System.IFormatProvider).formatProvider'></a>

`formatProvider` [System.IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IFormatProvider 'System.IFormatProvider')

format provider

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')