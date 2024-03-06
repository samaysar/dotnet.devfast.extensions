using System.Globalization;

namespace DevFast.Net.Extensions.SystemTypes
{
    /// <summary>
    /// Extension methods on <see cref="ReadOnlySpan{T}"/>.
    /// </summary>
    public static class ReadOnlySpan
    {
        #region TryTo on ReadOnlySpan<char>

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="bool"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out bool value)
        {
            return bool.TryParse(input, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="int"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out int value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return int.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="long"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out long value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return long.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="byte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out byte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return byte.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="sbyte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out sbyte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return sbyte.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="short"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out short value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return short.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="ushort"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out ushort value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ushort.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="uint"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out uint value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return uint.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="ulong"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out ulong value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ulong.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="float"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out float value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return float.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="double"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out double value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return double.TryParse(input, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="input"/> character span to <seealso cref="decimal"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="input">Character span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<char> input, out decimal value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return decimal.TryParse(input, style, formatProvider, out value);
        }

        #endregion TryTo on ReadOnlySpan<char>

#if NET8_0_OR_GREATER
        #region TryTo on ReadOnlySpan<byte>

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="int"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out int value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return int.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="long"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out long value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return long.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="byte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out byte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return byte.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="sbyte"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out sbyte value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return sbyte.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="short"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out short value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return short.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="ushort"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out ushort value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ushort.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="uint"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out uint value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return uint.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="ulong"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out ulong value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return ulong.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="float"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out float value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return float.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="double"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out double value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return double.TryParse(utf8Text, style, formatProvider, out value);
        }

        /// <summary>
        /// Tries parsing <paramref name="utf8Text"/> UTF-8 byte span to <seealso cref="decimal"/> value.
        /// Returns <see langword="true"/> if parsing is successful else <see langword="false"/>.
        /// </summary>
        /// <param name="utf8Text">UTF-8 byte span to parse</param>
        /// <param name="value">parsed value</param>
        /// <param name="style">style to use during parsing</param>
        /// <param name="formatProvider">format provider</param>
        public static bool TryTo(this ReadOnlySpan<byte> utf8Text, out decimal value, NumberStyles style = NumberStyles.Any,
            IFormatProvider? formatProvider = null)
        {
            return decimal.TryParse(utf8Text, style, formatProvider, out value);
        }

        #endregion TryTo on ReadOnlySpan<char>
#endif
    }
}