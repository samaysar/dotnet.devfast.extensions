﻿namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods to throw or consume various kind of exceptions.
/// </summary>
public static class Errors
{
    /// <summary>
    /// Throws an <see cref="Ioe"/> if <paramref name="flag"/> is <see langword="false"/>.
    /// Otherwise, always returns <see langword="true"/> for chaining purpose.
    /// </summary>
    /// <param name="flag">Flag value to check</param>
    /// <param name="message">Message of the <see cref="Ioe"/></param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ioe"/></param>
    public static bool ThrowInvalidOperationExceptionIfFalse(this bool flag,
        string message,
        Exception? innerException = null)
    {
        return flag ? true : throw new Ioe(message, innerException);
    }

    /// <summary>
    /// Throws an <see cref="Ioe"/> if <paramref name="flag"/> is <see langword="true"/>.
    /// Otherwise, always returns <see langword="false"/> for chaining purpose.
    /// </summary>
    /// <param name="flag">Flag value to check</param>
    /// <param name="message">Message of the <see cref="Ioe"/></param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ioe"/></param>
    public static bool ThrowInvalidOperationExceptionIfTrue(this bool flag,
        string message,
        Exception? innerException = null)
    {
        return flag ? throw new Ioe(message, innerException) : false;
    }

    /// <summary>
    /// Throws an <see cref="Ae"/> if <paramref name="predicate"/> is <see langword="false"/>.
    /// Otherwise, always returns <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="Ae"/> is thrown, the message will be
    /// '{argumentName} does not satisfy {predicateName}.',
    /// thus, a well-formed <paramref name="argumentName"/> and <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to evaluate predicate on</param>
    /// <param name="predicate">Predicate lambda</param>
    /// <param name="argumentName">Name of the argument</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ae"/></param>
    public static T ThrowArgumentExceptionOnPredicateFail<T>(this T value,
        Func<T, bool> predicate,
        string argumentName,
        string predicateName,
        Exception? innerException = null)
    {
        return predicate(value) ? value : throw new Ae($"{argumentName} does not satisfy {predicateName}.", innerException);
    }

    /// <summary>
    /// Throws an <see cref="Ae"/> if <paramref name="predicate"/> is <see langword="true"/>.
    /// Otherwise, always returns <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="Ae"/> is thrown, the message will be
    /// '{argumentName} satisfied {predicateName}.',
    /// thus, a well-formed <paramref name="argumentName"/> and <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to evaluate predicate on</param>
    /// <param name="predicate">Predicate lambda</param>
    /// <param name="argumentName">Name of the argument</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ae"/></param>
    public static T ThrowArgumentExceptionOnPredicateSuccess<T>(this T value,
        Func<T, bool> predicate,
        string argumentName,
        string predicateName,
        Exception? innerException = null)
    {
        return predicate(value) ? throw new Ae($"{argumentName} satisfied {predicateName}.", innerException) : value;
    }

    /// <summary>
    /// Throws an <see cref="Ae"/> if <paramref name="value"/> is <see langword="null"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="Ae"/> is thrown, the message will be '{argumentName} was null.',
    /// thus, a well-formed <paramref name="argumentName"/> will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ae"/></param>
    public static T ThrowArgumentExceptionForNull<T>(this T? value,
        string argumentName,
        Exception? innerException = null)
    {
        return value ?? throw new Ae($"{argumentName} was null.", innerException);
    }

    /// <summary>
    /// Throws an <see cref="Ae"/> if <paramref name="value"/> is <see langword="null"/>
    /// or if the <paramref name="predicate"/> evaluates to <see langword="false"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="Ae"/> is thrown, the message will be
    /// '{argumentName} does not satisfy {predicateName}.',
    /// thus, a well-formed <paramref name="argumentName"/> and/or <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="predicate">Predicate to evaluate</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ae"/></param>
    public static T ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T? value,
        Func<T, bool> predicate,
        string argumentName,
        string predicateName,
        Exception? innerException = null)
    {
        return value.ThrowArgumentExceptionForNull(argumentName, innerException).ThrowArgumentExceptionOnPredicateFail(predicate, argumentName, predicateName, innerException);
    }

    /// <summary>
    /// Throws an <see cref="Ae"/> if <paramref name="value"/> is <see langword="null"/>
    /// or if the <paramref name="predicate"/> evaluates to <see langword="true"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="Ae"/> is thrown, the message will be
    /// '{argumentName} satisfied {predicateName}.',
    /// thus, a well-formed <paramref name="argumentName"/> and/or <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="predicate">Predicate to evaluate</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="Ae"/></param>
    public static T ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T? value,
        Func<T, bool> predicate,
        string argumentName,
        string predicateName,
        Exception? innerException = null)
    {
        return value.ThrowArgumentExceptionForNull(argumentName, innerException).ThrowArgumentExceptionOnPredicateSuccess(predicate, argumentName, predicateName, innerException);
    }
}
