using System.Globalization;

namespace DevFast.Net.Extensions.Tests.SystemTypes
{
    [TestFixture]
    public class StringsTests
    {
        [Test]
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("           ", true)]
        [TestCase("     a      ", false)]
        [TestCase("anything", false)]
        public void IsNows_And_IsNotNows_Works_As_Expected(string? input, bool isnows)
        {
            Multiple(() =>
            {
                That(input.IsNows(), Is.EqualTo(isnows));
                That(input.IsNotNows(), Is.EqualTo(!isnows));
            });
        }

        [Test]
        [TestCase(null, "", "")]
        [TestCase("", "a", "")]
        [TestCase("      ", "a", "")]
        [TestCase(null, "a", "a")]
        [TestCase(null, "A", "A")]
        [TestCase("", "a", "")]
        [TestCase("      ", "a", "")]
        [TestCase(null, "  ", "  ")]
        [TestCase("", "  ", "")]
        [TestCase("   abc   ", "", "ABC")]
        public void TrimSafeAndUpper_Safely_Converts_String_To_Upper(string? input, string defaultVal, string expected)
        {
            CultureInfo english = new("en-US");
            That(input.TrimSafeAndUpper(defaultVal, english), Is.EqualTo(expected));
            That(input.TrimSafeAndUpper(defaultVal, english), Is.EqualTo(input.TrimSafeAndUpper(defaultVal)));
        }

        [Test]
        [TestCase(null, "", "")]
        [TestCase("", "A", "")]
        [TestCase("      ", "A", "")]
        [TestCase(null, "A", "A")]
        [TestCase(null, "a", "a")]
        [TestCase("", "A", "")]
        [TestCase("      ", "A", "")]
        [TestCase(null, "  ", "  ")]
        [TestCase("", "  ", "")]
        [TestCase("   A B C   ", "", "a b c")]
        public void TrimSafeAndLower_Safely_Converts_String_To_Lower(string? input, string defaultVal, string expected)
        {
            CultureInfo english = new("en-US");
            That(input.TrimSafeAndLower(defaultVal, english), Is.EqualTo(expected));
            That(input.TrimSafeAndLower(defaultVal, english), Is.EqualTo(input.TrimSafeAndLower(defaultVal)));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("           ", "")]
        [TestCase("   a        ", "a")]
        [TestCase("    A       ", "A")]
        [TestCase("    A     B  ", "A     B")]
        [TestCase("    AB  ", "AB")]
        [TestCase("AB  ", "AB")]
        [TestCase("    AB", "AB")]
        public void SafeTrimOrEmpty_Outcomes_Are_Consistent(string? input, string expectation)
        {
            That(input.TrimSafeOrEmpty(), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase(null, "", ' ', ',')]
        [TestCase("", "", ' ', ',')]
        [TestCase("        ,,   ", "", ' ', ',')]
        [TestCase("   ,a     ,   ", "a", ' ', ',')]
        [TestCase("    A   ,    ", "A", ' ', ',')]
        [TestCase("  , ,  A     B ,,, ", "A     B", ' ', ',', '\0')]
        [TestCase("    A,B  ", "A,B", ' ', ',')]
        [TestCase("AB  ", "AB", ' ')]
        [TestCase("    AB", "AB", ' ', char.MinValue)]
        public void SafeTrimOrEmpty_With_TrimChars_Gives_Consistent_Outcomes(string? input, string expectation,
            params char[] trimChars)
        {
            That(input.TrimSafeOrEmpty(trimChars), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase("", "")]
        [TestCase("           ", "")]
        [TestCase("   a        ", "a")]
        [TestCase("    A       ", "A")]
        [TestCase("    A     B  ", "A     B")]
        [TestCase("    AB  ", "AB")]
        [TestCase("AB  ", "AB")]
        [TestCase("    AB", "AB")]
        public void SafeTrimOrNull_Outcomes_Are_Consistent(string? input, string? expectation)
        {
            That(input.TrimSafeOrNull(), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase(null, null, ' ', ',')]
        [TestCase("", "", ' ', ',')]
        [TestCase("        ,,   ", "", ' ', ',')]
        [TestCase("   ,a     ,   ", "a", ' ', ',')]
        [TestCase("    A   ,    ", "A", ' ', ',')]
        [TestCase("  , ,  A     B ,,, ", "A     B", ' ', ',', '\0')]
        [TestCase("    A,B  ", "A,B", ' ', ',')]
        [TestCase("AB  ", "AB", ' ')]
        [TestCase("    AB", "AB", ' ', char.MinValue)]
        public void SafeTrimOrNull_With_TrimChars_Gives_Consistent_Outcomes(string? input, string? expectation,
            params char[] trimChars)
        {
            That(input.TrimSafeOrNull(trimChars), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase(null, null, null)]
        [TestCase("", "", "")]
        [TestCase("           ", "", "aaaa")]
        [TestCase("   a        ", "a", "aaaa")]
        [TestCase("    A       ", "A", "aaaa")]
        [TestCase("    A     B  ", "A     B", null)]
        [TestCase("    AB  ", "AB", "QA")]
        [TestCase("AB  ", "AB", "        ")]
        [TestCase("    AB", "AB", "  A ")]
        public void SafeTrimOrDefault_Outcomes_Are_Consistent(string? input, string? expectation, string? defaultVal)
        {
            That(input.TrimSafeOrDefault(defaultVal), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase(null, "A", "A", ' ', ',')]
        [TestCase("", "", " a w ", ' ', ',')]
        [TestCase("        ,,   ", "", "aFw", ' ', ',')]
        [TestCase("   ,a     ,   ", "a", null, ' ', ',')]
        [TestCase("    A   ,    ", "A", null, ' ', ',')]
        [TestCase("  , ,  A     B ,,, ", "A     B", null, ' ', ',', '\0')]
        [TestCase("    A,B  ", "A,B", null, ' ', ',')]
        [TestCase("AB  ", "AB", null, ' ')]
        [TestCase("    AB", "AB", null, ' ', char.MinValue)]
        public void SafeTrimOrDefault_With_TrimChars_Gives_Consistent_Outcomes(string? input, string? expectation,
            string? defaultVal, params char[] trimChars)
        {
            That(input.TrimSafeOrDefault(defaultVal, trimChars), Is.EqualTo(expectation));
        }

        [Test]
        [TestCase("true", true, true)]
        [TestCase("false", false, true)]
        [TestCase("  true   ", true, true)]
        [TestCase(" false  ", false, true)]
        [TestCase("  TRUE   ", true, true)]
        [TestCase(" FALSE  ", false, true)]
        [TestCase("  TRuE   ", true, true)]
        [TestCase(" FAlsE  ", false, true)]
        [TestCase("notbool", default(bool), false)]
        [TestCase("boolean", default(bool), false)]
        [TestCase(" invalid_bool ", default(bool), false)]
        [TestCase("       ", default(bool), false)]
        [TestCase("", default(bool), false)]
        [TestCase(null, default(bool), false)]
        public void TryTo_Bool_Works_As_Expected(string? input, bool expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out bool outcome), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("true", "", false)]
        [TestCase("false", "", false)]
        [TestCase("c50bfbfe-d319-40e8-9998-33eb35b74b87", "c50bfbfed31940e8999833eb35b74b87", true)]
        [TestCase(" c50bfbfe-d319-40e8-9998-33eb35b74b87  ", "c50bfbfed31940e8999833eb35b74b87", true)]
        [TestCase("  C50BFBFE-D319-40E8-9998-33EB35B74B87   ", "c50bfbfed31940e8999833eb35b74b87", true)]
        [TestCase(null, "", false)]
        public void TryTo_Guid_Works_As_Expected(string? input, string expected, bool returnVal)
        {
            Multiple(() =>
            {
                bool success = input.TryTo(out Guid outcome);
                That(success, Is.EqualTo(returnVal));
                if (success)
                {
                    That(outcome.ToString("N"), Is.EqualTo(expected));
                }
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(int), false)]
        [TestCase("", NumberStyles.Any, null, default(int), false)]
        [TestCase(null, NumberStyles.Any, null, default(int), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(int), false)]
        [TestCase("a2", NumberStyles.Any, null, default(int), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(int), false)]
        [TestCase("3_", NumberStyles.Any, null, default(int), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(int), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(int), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(int), false)]
        [TestCase("3.0000", NumberStyles.Any, null, 3, true)]
        [TestCase("-2147483648", NumberStyles.Any, null, int.MinValue, true)]
        [TestCase("2147483647", NumberStyles.Any, null, int.MaxValue, true)]
        [TestCase("-2 147 483 648", NumberStyles.Any, "fr-FR", int.MinValue, true)]
        [TestCase("2 147 483 647", NumberStyles.Any, "fr-FR", int.MaxValue, true)]
        public void TryTo_Int_Works_As_Expected(string? input, NumberStyles style, string? provider,
            int expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out int outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(long), false)]
        [TestCase("", NumberStyles.Any, null, default(long), false)]
        [TestCase(null, NumberStyles.Any, null, default(long), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(long), false)]
        [TestCase("a2", NumberStyles.Any, null, default(long), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(long), false)]
        [TestCase("3_", NumberStyles.Any, null, default(long), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(long), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(long), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(long), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (long)3, true)]
        [TestCase("-2147483648", NumberStyles.Any, null, int.MinValue, true)]
        [TestCase("2147483647", NumberStyles.Any, null, int.MaxValue, true)]
        [TestCase("-2 147 483 648", NumberStyles.Any, "fr-FR", int.MinValue, true)]
        [TestCase("2 147 483 647", NumberStyles.Any, "fr-FR", int.MaxValue, true)]
        [TestCase("-9223372036854775808", NumberStyles.Any, null, long.MinValue, true)]
        [TestCase("9223372036854775807", NumberStyles.Any, null, long.MaxValue, true)]
        [TestCase("-9 223 372 036 854 775 808", NumberStyles.Any, "fr-FR", long.MinValue, true)]
        [TestCase("9 223 372 036 854 775 807", NumberStyles.Any, "fr-FR", long.MaxValue, true)]
        public void TryTo_Long_Works_As_Expected(string? input, NumberStyles style, string? provider,
            long expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out long outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(byte), false)]
        [TestCase("", NumberStyles.Any, null, default(byte), false)]
        [TestCase(null, NumberStyles.Any, null, default(byte), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(byte), false)]
        [TestCase("a2", NumberStyles.Any, null, default(byte), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(byte), false)]
        [TestCase("3_", NumberStyles.Any, null, default(byte), false)]
        [TestCase("3.1", NumberStyles.Any, null, default(byte), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(byte), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(byte), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (byte)3, true)]
        [TestCase("0", NumberStyles.Any, null, byte.MinValue, true)]
        [TestCase("255", NumberStyles.Any, null, byte.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, "fr-FR", byte.MinValue, true)]
        [TestCase("255", NumberStyles.Any, "fr-FR", byte.MaxValue, true)]
        public void TryTo_Byte_Works_As_Expected(string? input, NumberStyles style, string? provider,
            byte expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out byte outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase(null, NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("a2", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("3_", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("3.1", NumberStyles.Any, null, default(sbyte), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(sbyte), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(sbyte), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (sbyte)3, true)]
        [TestCase("-128", NumberStyles.Any, null, sbyte.MinValue, true)]
        [TestCase("127", NumberStyles.Any, null, sbyte.MaxValue, true)]
        [TestCase("-128", NumberStyles.Any, "fr-FR", sbyte.MinValue, true)]
        [TestCase("127", NumberStyles.Any, "fr-FR", sbyte.MaxValue, true)]
        public void TryTo_SByte_Works_As_Expected(string? input, NumberStyles style, string? provider,
            sbyte expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out sbyte outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(short), false)]
        [TestCase("", NumberStyles.Any, null, default(short), false)]
        [TestCase(null, NumberStyles.Any, null, default(short), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(short), false)]
        [TestCase("a2", NumberStyles.Any, null, default(short), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(short), false)]
        [TestCase("3_", NumberStyles.Any, null, default(short), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(short), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(short), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(short), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (short)3, true)]
        [TestCase("-32768", NumberStyles.Any, null, short.MinValue, true)]
        [TestCase("32767", NumberStyles.Any, null, short.MaxValue, true)]
        [TestCase("-32 768", NumberStyles.Any, "fr-FR", short.MinValue, true)]
        [TestCase("32 767", NumberStyles.Any, "fr-FR", short.MaxValue, true)]
        public void TryTo_Short_Works_As_Expected(string? input, NumberStyles style, string? provider,
            short expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out short outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("", NumberStyles.Any, null, default(ushort), false)]
        [TestCase(null, NumberStyles.Any, null, default(ushort), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("a2", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("3_", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(ushort), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(ushort), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(ushort), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (ushort)3, true)]
        [TestCase("0", NumberStyles.Any, null, ushort.MinValue, true)]
        [TestCase("65535", NumberStyles.Any, null, ushort.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, "fr-FR", ushort.MinValue, true)]
        [TestCase("65 535", NumberStyles.Any, "fr-FR", ushort.MaxValue, true)]
        public void TryTo_UShort_Works_As_Expected(string? input, NumberStyles style, string? provider,
            ushort expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out ushort outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(uint), false)]
        [TestCase("", NumberStyles.Any, null, default(uint), false)]
        [TestCase(null, NumberStyles.Any, null, default(uint), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(uint), false)]
        [TestCase("a2", NumberStyles.Any, null, default(uint), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(uint), false)]
        [TestCase("3_", NumberStyles.Any, null, default(uint), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(uint), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(uint), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(uint), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (uint)3, true)]
        [TestCase("0", NumberStyles.Any, null, uint.MinValue, true)]
        [TestCase("4294967295", NumberStyles.Any, null, uint.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, "fr-FR", uint.MinValue, true)]
        [TestCase("4 294 967 295", NumberStyles.Any, "fr-FR", uint.MaxValue, true)]
        public void TryTo_UInt_Works_As_Expected(string? input, NumberStyles style, string? provider,
            uint expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out uint outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("", NumberStyles.Any, null, default(ulong), false)]
        [TestCase(null, NumberStyles.Any, null, default(ulong), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("a2", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("3_", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("3.0001", NumberStyles.Any, null, default(ulong), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(ulong), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(ulong), false)]
        [TestCase("3.0000", NumberStyles.Any, null, (ulong)3, true)]
        [TestCase("0", NumberStyles.Any, null, uint.MinValue, true)]
        [TestCase("4294967295", NumberStyles.Any, null, uint.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, "fr-FR", uint.MinValue, true)]
        [TestCase("4 294 967 295", NumberStyles.Any, "fr-FR", uint.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, null, ulong.MinValue, true)]
        [TestCase("18446744073709551615", NumberStyles.Any, null, ulong.MaxValue, true)]
        [TestCase("0", NumberStyles.Any, "fr-FR", ulong.MinValue, true)]
        [TestCase("18 446 744 073 709 551 615", NumberStyles.Any, "fr-FR", ulong.MaxValue, true)]
        public void TryTo_ULong_Works_As_Expected(string? input, NumberStyles style, string? provider,
            ulong expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out ulong outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(float), false)]
        [TestCase("", NumberStyles.Any, null, default(float), false)]
        [TestCase(null, NumberStyles.Any, null, default(float), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(float), false)]
        [TestCase("a2", NumberStyles.Any, null, default(float), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(float), false)]
        [TestCase("3_", NumberStyles.Any, null, default(float), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(float), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(float), false)]
        [TestCase("3.0001", NumberStyles.Any, null, (float)3.0001, true)]
        [TestCase("3.0000", NumberStyles.Any, null, (float)3, true)]
        [TestCase("-3.40282", NumberStyles.Any, null, (float)-3.40282, true)]
        [TestCase("3.40282", NumberStyles.Any, null, (float)3.40282, true)]
        [TestCase("-3,40282", NumberStyles.Any, "fr-FR", (float)-3.40282, true)]
        [TestCase("3,40282", NumberStyles.Any, "fr-FR", (float)3.40282, true)]
        public void TryTo_Float_Works_As_Expected(string? input, NumberStyles style, string? provider,
            float expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out float outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null, default(double), false)]
        [TestCase("", NumberStyles.Any, null, default(double), false)]
        [TestCase(null, NumberStyles.Any, null, default(double), false)]
        [TestCase("    a3   ", NumberStyles.Any, null, default(double), false)]
        [TestCase("a2", NumberStyles.Any, null, default(double), false)]
        [TestCase("3a123", NumberStyles.Any, null, default(double), false)]
        [TestCase("3_", NumberStyles.Any, null, default(double), false)]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null, default(double), false)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, null, default(double), false)]
        [TestCase("3.0001", NumberStyles.Any, null, 3.0001, true)]
        [TestCase("3.0000", NumberStyles.Any, null, (double)3, true)]
        [TestCase("-3.40282", NumberStyles.Any, null, -3.40282, true)]
        [TestCase("3.40282", NumberStyles.Any, null, 3.40282, true)]
        [TestCase("-3,40282", NumberStyles.Any, "fr-FR", -3.40282, true)]
        [TestCase("3,40282", NumberStyles.Any, "fr-FR", 3.40282, true)]
        public void TryTo_Double_Works_As_Expected(string? input, NumberStyles style, string? provider,
            double expected, bool returnVal)
        {
            Multiple(() =>
            {
                That(input.TryTo(out double outcome, style,
                    string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.EqualTo(returnVal));
                That(outcome, Is.EqualTo(expected));
            });
        }

        [Test]
        [TestCase("       ", NumberStyles.Any, null)]
        [TestCase("", NumberStyles.Any, "fr-FR")]
        [TestCase(null, NumberStyles.Any, null)]
        [TestCase("    a3   ", NumberStyles.Any, null)]
        [TestCase("a2", NumberStyles.Any, "fr-FR")]
        [TestCase("3a123", NumberStyles.Any, null)]
        [TestCase("3_", NumberStyles.Any, "fr-FR")]
        [TestCase("3    ", NumberStyles.AllowLeadingWhite, null)]
        [TestCase("   3", NumberStyles.AllowTrailingWhite, "fr-FR")]
        public void TryTo_Decimal_When_Return_Value_Is_False(string? input, NumberStyles style,
            string? provider)
        {
            Multiple(() =>
            {
                That(input.TryTo(out decimal outcome, style, string.IsNullOrWhiteSpace(provider) ? null : new CultureInfo(provider)), Is.False);
                That(outcome, Is.EqualTo(0));
            });
        }

        [Test]
        public void TryTo_Decimal_When_Return_Value_Is_True()
        {
            Multiple(() =>
            {
                That("3.0001".TryTo(out decimal outcome), Is.True);
                That(outcome, Is.EqualTo(3.0001m));
                That("3.0000".TryTo(out outcome), Is.True);
                That(outcome, Is.EqualTo(3.0000m));
                That("3.40282".TryTo(out outcome), Is.True);
                That(outcome, Is.EqualTo(3.40282m));
                That("-3.40282".TryTo(out outcome), Is.True);
                That(outcome, Is.EqualTo(-3.40282m));
                That("3,40282".TryTo(out outcome, NumberStyles.Any, new CultureInfo("fr-FR")), Is.True);
                That(outcome, Is.EqualTo(3.40282m));
                That("-3,40282".TryTo(out outcome, NumberStyles.Any, new CultureInfo("fr-FR")), Is.True);
                That(outcome, Is.EqualTo(-3.40282m));
            });
        }

#if NET6_0_OR_GREATER

        [Test]
        [TestCase("2001-01-01", "yyyy-MM-dd", true)]
        [TestCase("2001-01-01", "yyyy-MM-dd", true)]
        [TestCase("2001-25-01", "yyyy-MM-dd", false)]
        [TestCase("2001-21-01", "yyyy-MM-dd", false)]
        [TestCase("01-01-2001", "MM-dd-yyyy", true)]
        [TestCase("01-01-2001", "MM-dd-yyyy", true)]
        [TestCase("25-01-2001", "MM-dd-yyyy", false)]
        [TestCase("21-01-2001", "MM-dd-yyyy", false)]
        public void TryTo_DateOnly_Works_As_Expected_With_Given_Format(string input, string format,
            bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateOnly ts, format), Is.True);
                That(new DateOnly(2001, 01, 01), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateOnly ts, format), Is.False);
                That(default(DateOnly), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("2001-01-01", "MM-dd-yyyy|yyyy-MM-dd", true)]
        [TestCase("2001-01-01", "MM-dd-yyyy|yyyy-MM-dd", true)]
        [TestCase("2001-25-01", "MM-dd-yyyy|yyyy-MM-dd", false)]
        [TestCase("2001-21-01", "MM-dd-yyyy|yyyy-MM-dd", false)]
        [TestCase("01-01-2001", "yyyy-MM-dd|MM-dd-yyyy", true)]
        [TestCase("01-01-2001", "yyyy-MM-dd|MM-dd-yyyy", true)]
        [TestCase("25-01-2001", "yyyy-MM-dd|MM-dd-yyyy", false)]
        [TestCase("21-01-2001", "yyyy-MM-dd|MM-dd-yyyy", false)]
        public void TryTo_DateOnly_Works_As_Expected_With_Format_Collection(string input,
            string formatBarSeparated, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateOnly ts, formatBarSeparated.Split('|')), Is.True);
                That(new DateOnly(2001, 01, 01), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateOnly ts, formatBarSeparated.Split('|')), Is.False);
                That(default(DateOnly), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("2001-01-01", true)]
        [TestCase("2001-01-01", true)]
        [TestCase("2001-32-01", false)]
        [TestCase("2001-01-01", true)]
        [TestCase("01-01-2001", true)]
        [TestCase("01-32-2001", false)]
        [TestCase("01-00-2001", false)]
        [TestCase("12-31-2001", true)]
        public void TryTo_DateOnly_Works_As_Expected_With_No_Format(string input, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateOnly ts), Is.True);
                That(DateOnly.Parse(input), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateOnly ts), Is.False);
                That(default(DateOnly), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("00:00:00", "hh:mm:ss", true)]
        [TestCase("00:00:00", "HH:mm:ss", true)]
        [TestCase("25:00:00", "HH:mm:ss", false)]
        [TestCase("15:00:00", "hh:mm:ss", false)]
        [TestCase("00:00:00", "hh:mm:ss", true)]
        [TestCase("00:00:00", "HH:mm:ss", true)]
        [TestCase("25:00:00", "HH:mm:ss", false)]
        [TestCase("15:00:00", "hh:mm:ss", false)]
        public void TryTo_TimeOnly_Works_As_Expected_With_Given_Format(string input, string format,
            bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out TimeOnly ts, format), Is.True);
                That(new TimeOnly(0, 0, 0), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out TimeOnly ts, format), Is.False);
                That(default(TimeOnly), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("00:00:00", "hh:mm:ss|hh:mm:ss", true)]
        [TestCase("00:00:00", "hh:mm:ss|HH:mm:ss", true)]
        [TestCase("25:00:00", "hh:mm:ss|HH:mm:ss", false)]
        [TestCase("15:00:00", "hh:mm:ss|hh:mm:ss", false)]
        [TestCase("00:00:00", "hh:mm:ss|hh:mm:ss", true)]
        [TestCase("00:00:00", "hh:mm:ss|HH:mm:ss", true)]
        [TestCase("25:00:00", "hh:mm:ss|HH:mm:ss", false)]
        [TestCase("15:00:00", "hh:mm:ss|hh:mm:ss", false)]
        public void TryTo_TimeOnly_Works_As_Expected_With_Format_Collection(string input,
            string formatBarSeparated, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out TimeOnly ts, formatBarSeparated.Split('|')), Is.True);
                That(new TimeOnly(0, 0, 0), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out TimeOnly ts, formatBarSeparated.Split('|')), Is.False);
                That(default(TimeOnly), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("00:00:00", true)]
        [TestCase("00:00:00", true)]
        [TestCase("25:00:00", false)]
        [TestCase("15:00:00", true)]
        [TestCase("00:00:00", true)]
        [TestCase("60:60:60", false)]
        [TestCase("25:00:00", false)]
        [TestCase("23:59:59", true)]
        public void TryTo_TimeOnly_Works_As_Expected_With_No_Format(string input, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out TimeOnly ts), Is.True);
                That(TimeOnly.Parse(input), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out TimeOnly ts), Is.False);
                That(default(TimeOnly), Is.EqualTo(ts));
            }
        }

#endif

        [Test]
        [TestCase("2001-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss", true)]
        [TestCase("2001-01-01 00:00:00", "yyyy-MM-dd HH:mm:ss", true)]
        [TestCase("2001-01-01 25:00:00", "yyyy-MM-dd HH:mm:ss", false)]
        [TestCase("2001-01-01 15:00:00", "yyyy-MM-dd hh:mm:ss", false)]
        [TestCase("01-01-2001 00:00:00", "MM-dd-yyyy hh:mm:ss", true)]
        [TestCase("01-01-2001 00:00:00", "MM-dd-yyyy HH:mm:ss", true)]
        [TestCase("01-01-2001 25:00:00", "MM-dd-yyyy HH:mm:ss", false)]
        [TestCase("01-01-2001 15:00:00", "MM-dd-yyyy hh:mm:ss", false)]
        public void TryTo_DateTime_Works_As_Expected_With_Given_Format(string input, string format,
            bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateTime ts, format), Is.True);
                That(new DateTime(2001, 01, 01, 0, 0, 0), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateTime ts, format), Is.False);
                That(default(DateTime), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("2001-01-01 00:00:00", "MM-dd-yyyy hh:mm:ss|yyyy-MM-dd hh:mm:ss", true)]
        [TestCase("2001-01-01 00:00:00", "MM-dd-yyyy hh:mm:ss|yyyy-MM-dd HH:mm:ss", true)]
        [TestCase("2001-01-01 25:00:00", "MM-dd-yyyy hh:mm:ss|yyyy-MM-dd HH:mm:ss", false)]
        [TestCase("2001-01-01 15:00:00", "MM-dd-yyyy hh:mm:ss|yyyy-MM-dd hh:mm:ss", false)]
        [TestCase("01-01-2001 00:00:00", "yyyy-MM-dd hh:mm:ss|MM-dd-yyyy hh:mm:ss", true)]
        [TestCase("01-01-2001 00:00:00", "yyyy-MM-dd hh:mm:ss|MM-dd-yyyy HH:mm:ss", true)]
        [TestCase("01-01-2001 25:00:00", "yyyy-MM-dd hh:mm:ss|MM-dd-yyyy HH:mm:ss", false)]
        [TestCase("01-01-2001 15:00:00", "yyyy-MM-dd hh:mm:ss|MM-dd-yyyy hh:mm:ss", false)]
        public void TryTo_DateTime_Works_As_Expected_With_Format_Collection(string input,
            string formatBarSeparated, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateTime ts, formatBarSeparated.Split('|')), Is.True);
                That(new DateTime(2001, 01, 01, 0, 0, 0), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateTime ts, formatBarSeparated.Split('|')), Is.False);
                That(default(DateTime), Is.EqualTo(ts));
            }
        }

        [Test]
        [TestCase("2001-01-01 00:00:00", true)]
        [TestCase("2001-01-01 00:00:00", true)]
        [TestCase("2001-01-01 25:00:00", false)]
        [TestCase("2001-01-01 15:00:00", true)]
        [TestCase("01-01-2001 00:00:00", true)]
        [TestCase("01-01-2001 60:60:60", false)]
        [TestCase("01-01-2001 25:00:00", false)]
        [TestCase("12-31-2001 23:59:59", true)]
        public void TryTo_DateTime_Works_As_Expected_With_No_Format(string input, bool expectedReturn)
        {
            if (expectedReturn)
            {
                That(input.TryTo(out DateTime ts), Is.True);
                That(DateTime.Parse(input), Is.EqualTo(ts));
            }
            else
            {
                That(input.TryTo(out DateTime ts), Is.False);
                That(default(DateTime), Is.EqualTo(ts));
            }
        }
    }
}
