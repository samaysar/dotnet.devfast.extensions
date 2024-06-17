namespace DevFast.Net.Extensions.SystemTypes;

/// <summary>
/// Extension methods to throw various kind of exceptions.
/// </summary>
public static class ExceptionThrow
{
    /// <summary>
    /// Throws an 
    /// </summary>
    public static void ThrowInvalidOperationExceptionIfFalse(this bool flag, string message, Exception? innerException = null)
    {
        if (!flag)
        {
            throw new InvalidOperationException(message, innerException);
        }
    }
}
