namespace DevFast.Net.Extensions.SystemTypes;

/// <summary>
/// Extension methods to throw various kind of exceptions.
/// </summary>
public static class ExceptionThrow
{
    /// <summary>
    /// Throws an <see cref="InvalidOperationException"/> if <paramref name="flag"/> is <see langword="false"/>.
    /// Otherwise, always returns <see langword="true"/> for chaining purpose.
    /// </summary>
    /// <param name="flag">Flag value to check</param>
    /// <param name="message">Message of the <see cref="InvalidOperationException"/></param>
    /// <param name="innerException">Inner exceptions of the <see cref="InvalidOperationException"/></param>
    public static bool ThrowInvalidOperationExceptionIfFalse(this bool flag, string message, Exception? innerException = null)
    {
        return flag ? true : throw new InvalidOperationException(message, innerException);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="value"/> is <see langword="null"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="ArgumentException"/> is thrown, the message will be '{argumentName} was null.',
    /// thus, a well-formed <paramref name="argumentName"/> will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="innerException">Inner exceptions of the <see cref="ArgumentException"/></param>
    public static T ThrowArgumentExceptionForNull<T>(this T? value, string argumentName, Exception? innerException = null)
        where T : class
    {
        return value ?? throw new ArgumentException($"{argumentName} was null.", innerException);
    }
}
