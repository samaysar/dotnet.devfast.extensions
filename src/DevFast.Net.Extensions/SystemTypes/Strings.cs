using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DevFast.Net.Extensions.SystemTypes
{
    /// <summary>
    /// Extension methods on <see cref="string"/>.
    /// </summary>
    public static class Strings
    {
        /// <summary>
        /// Checks whether <paramref name="input"/> is NullOrWhiteSpace string.
        /// </summary>
        /// <param name="input">string to check</param>
        public static bool IsNows([NotNullWhen(false)] this string? input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Checks whether <paramref name="input"/> is NOT NullOrWhiteSpace string.
        /// </summary>
        /// <param name="input">string to check</param>
        public static bool IsNotNows([NotNullWhen(true)] this string? input)
        {
            return !input.IsNows();
        }

        /// <summary>
        /// Trims and converts the <paramref name="input"/> string based on given culture
        /// (if not supplied then <seealso cref="CultureInfo.InvariantCulture"/> is used).
        /// If <paramref name="input"/> is <see langword="null"/>, returns the provided
        /// <paramref name="defaultValue"/> (without trimming and case-conversion!).
        /// </summary>
        /// <param name="input">value to operate on</param>
        /// <param name="defaultValue">return value in case, supplied value is <see langword="null"/></param>
        /// <param name="culture">Culture to use, if null or not supplied, then <seealso cref="CultureInfo.InvariantCulture"/> is used.</param>
        public static string TrimSafeAndUpper(this string? input, string defaultValue = "", CultureInfo? culture = null)
        {
            return input?.Trim().ToUpper(culture ?? CultureInfo.InvariantCulture) ?? defaultValue;
        }

        /// <summary>
        /// Trims and converts the <paramref name="input"/> string based on given culture
        /// (if not supplied then <seealso cref="CultureInfo.InvariantCulture"/> is used).
        /// If <paramref name="input"/> is <see langword="null"/>, returns the provided
        /// <paramref name="defaultValue"/> (without trimming and case-conversion!).
        /// </summary>
        /// <param name="input">value to operate on</param>
        /// <param name="defaultValue">return value in case, supplied value is <see langword="null"/></param>
        /// <param name="culture">Culture to use, if <see langword="null"/> or not supplied, then <seealso cref="CultureInfo.InvariantCulture"/> is used.</param>
        public static string TrimSafeAndLower(this string? input, string defaultValue = "", CultureInfo? culture = null)
        {
            return input?.Trim().ToLower(culture ?? CultureInfo.InvariantCulture) ?? defaultValue;
        }

        /// <summary>
        /// If value is <see langword="null"/>, <seealso cref="string.Empty"/> is returned;
        /// otherwise trimmed string is returned.
        /// </summary>
        /// <param name="input">Value to trim safe</param>
        /// <param name="trimChars">optional. when not given any char set,
        /// whitespaces will be removed</param>
        public static string TrimSafeOrEmpty(this string? input, params char[]? trimChars)
        {
            return input.TrimSafeOrDefault(string.Empty, trimChars)!;
        }

        /// <summary>
        /// If value is <see langword="null"/>, <see langword="null"/> is returned;
        /// otherwise trimmed string is returned.
        /// </summary>
        /// <param name="input">Value to trim safe</param>
        /// <param name="trimChars">optional. when not given any char set,
        /// whitespaces will be removed</param>
        public static string? TrimSafeOrNull(this string? input, params char[]? trimChars)
        {
            return input.TrimSafeOrDefault(null, trimChars);
        }

        /// <summary>
        /// If value is <see langword="null"/>, provided <paramref name="defaultValue"/> is returned;
        /// otherwise trimmed string is returned.
        /// </summary>
        /// <param name="input">Value to trim safe</param>
        /// <param name="defaultValue">default value to return when input is null.</param>
        /// <param name="trimChars">optional. when not given any char set,
        /// whitespaces will be removed</param>
        public static string? TrimSafeOrDefault(this string? input, string? defaultValue, params char[]? trimChars)
        {
            return input?.Trim(trimChars) ?? defaultValue;
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="bool"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out bool value)
        {
            return bool.TryParse(input, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="Guid"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out Guid value)
        {
            return Guid.TryParse(input, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="int"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out int value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return int.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="long"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out long value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return long.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="byte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out byte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return byte.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="sbyte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out sbyte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return sbyte.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="short"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out short value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return short.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="ushort"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out ushort value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ushort.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="uint"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out uint value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return uint.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="ulong"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out ulong value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ulong.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="float"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out float value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return float.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="double"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out double value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return double.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="decimal"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out decimal value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return decimal.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateOnly value, DateTimeStyles style = DateTimeStyles.None,
            IFormatProvider? formatProvider = null)
        {
            return DateOnly.TryParse(input, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="format">Date-only format to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateOnly value, string format,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return DateOnly.TryParseExact(input, format, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="formats">Date-only formats to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateOnly value, string[] formats,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return DateOnly.TryParseExact(input, formats, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="TimeOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out TimeOnly value, DateTimeStyles style = DateTimeStyles.None,
            IFormatProvider? formatProvider = null)
        {
            return TimeOnly.TryParse(input, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="TimeOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="format">Time-only format to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out TimeOnly value, string format,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return TimeOnly.TryParseExact(input, format, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="TimeOnly"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="formats">Time-only formats to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out TimeOnly value, string[] formats,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return TimeOnly.TryParseExact(input, formats, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateTime"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateTime value, DateTimeStyles style = DateTimeStyles.None,
            IFormatProvider? formatProvider = null)
        {
            return DateTime.TryParse(input, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateTime"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="format">DateTime format to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateTime value, string format,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return DateTime.TryParseExact(input, format, formatProvider, style, out value);
        }

        /// <summary>
        /// Tries parsing <seealso cref="string"/> to <seealso cref="DateTime"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">string to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="formats">DateTime formats to use.</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo([NotNullWhen(true)] this string? input, out DateTime value, string[] formats,
            DateTimeStyles style = DateTimeStyles.None, IFormatProvider? formatProvider = null)
        {
            return DateTime.TryParseExact(input, formats, formatProvider, style, out value);
        }
    }
}
