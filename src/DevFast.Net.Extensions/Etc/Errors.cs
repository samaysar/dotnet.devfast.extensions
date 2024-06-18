using System.Runtime.ExceptionServices;

namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods to throw or consume various kind of exceptions.
/// </summary>
public static class Errors
{
    /// <summary>
    /// Throws an <see cref="InvalidOperationException"/> if <paramref name="flag"/> is <see langword="false"/>.
    /// Otherwise, always returns <see langword="true"/> for chaining purpose.
    /// </summary>
    /// <param name="flag">Flag value to check</param>
    /// <param name="message">Message of the <see cref="InvalidOperationException"/></param>
    /// <param name="innerException">Inner exceptions of the <see cref="InvalidOperationException"/></param>
    public static bool ThrowInvalidOperationExceptionIfFalse(this bool flag,
        string message,
        Exception? innerException = null)
    {
        return flag ? true : throw new InvalidOperationException(message, innerException);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="predicate"/> is <see langword="false"/>.
    /// Otherwise, always returns <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="ArgumentException"/> is thrown, the message will be
    /// '{argumentName} does not satisfy {predicateName ?? predicate}.',
    /// thus, a well-formed <paramref name="argumentName"/> and <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to evaluate predicate on</param>
    /// <param name="predicate">Predicate lambda</param>
    /// <param name="argumentName">Name of the argument</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="ArgumentException"/></param>
    public static T ThrowArgumentExceptionOnPredicateFail<T>(this T value,
        Func<T, bool> predicate,
        string argumentName,
        string? predicateName = null,
        Exception? innerException = null)
    {
        return predicate(value) ? value : throw new ArgumentException($"{argumentName} does not satisfy {predicateName ?? nameof(predicate)}.", innerException);
    }

    /// <summary>
    /// Throws an <see cref="InvalidOperationException"/> if <paramref name="flag"/> is <see langword="true"/>.
    /// Otherwise, always returns <see langword="false"/> for chaining purpose.
    /// </summary>
    /// <param name="flag">Flag value to check</param>
    /// <param name="message">Message of the <see cref="InvalidOperationException"/></param>
    /// <param name="innerException">Inner exceptions of the <see cref="InvalidOperationException"/></param>
    public static bool ThrowInvalidOperationExceptionIfTrue(this bool flag,
        string message,
        Exception? innerException = null)
    {
        return flag ? throw new InvalidOperationException(message, innerException) : false;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="predicate"/> is <see langword="true"/>.
    /// Otherwise, always returns <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="ArgumentException"/> is thrown, the message will be
    /// '{argumentName} satisfied {predicateName ?? predicate}.',
    /// thus, a well-formed <paramref name="argumentName"/> and <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to evaluate predicate on</param>
    /// <param name="predicate">Predicate lambda</param>
    /// <param name="argumentName">Name of the argument</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="ArgumentException"/></param>
    public static T ThrowArgumentExceptionOnPredicateSuccess<T>(this T value,
        Func<T, bool> predicate,
        string argumentName,
        string? predicateName = null,
        Exception? innerException = null)
    {
        return predicate(value) ? throw new ArgumentException($"{argumentName} satisfied {predicateName ?? nameof(predicate)}.", innerException) : value;
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
    public static T ThrowArgumentExceptionForNull<T>(this T? value,
        string argumentName,
        Exception? innerException = null)
    {
        return value ?? throw new ArgumentException($"{argumentName} was null.", innerException);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="value"/> is <see langword="null"/>
    /// or if the <paramref name="predicate"/> evaluates to <see langword="false"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="ArgumentException"/> is thrown, the message will be
    /// '{argumentName} does not satisfy {predicateName ?? predicate}.',
    /// thus, a well-formed <paramref name="argumentName"/> and/or <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="predicate">Predicate to evaluate</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="ArgumentException"/></param>
    public static T ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T? value,
        Func<T, bool> predicate,
        string argumentName,
        string? predicateName = null,
        Exception? innerException = null)
    {
        return value.ThrowArgumentExceptionForNull(argumentName, innerException).ThrowArgumentExceptionOnPredicateFail(predicate, argumentName, predicateName);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="value"/> is <see langword="null"/>
    /// or if the <paramref name="predicate"/> evaluates to <see langword="true"/>.
    /// Otherwise, returns the <paramref name="value"/> for chaining purpose.
    /// <para>
    /// NOTE: If <see cref="ArgumentException"/> is thrown, the message will be
    /// '{argumentName} satisfied {predicateName ?? predicate}.',
    /// thus, a well-formed <paramref name="argumentName"/> and/or <paramref name="predicateName"/>
    /// will make more sense during debugging or log-analysis.
    /// </para>
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="predicate">Predicate to evaluate</param>
    /// <param name="argumentName">Name of the argument supplied as value</param>
    /// <param name="predicateName">Name of the predicate</param>
    /// <param name="innerException">Inner exceptions of the <see cref="ArgumentException"/></param>
    public static T ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T? value,
        Func<T, bool> predicate,
        string argumentName,
        string? predicateName = null,
        Exception? innerException = null)
    {
        return value.ThrowArgumentExceptionForNull(argumentName, innerException).ThrowArgumentExceptionOnPredicateSuccess(predicate, argumentName, predicateName);
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block.
    /// If any exception of type <typeparamref name="T"/> (or
    /// derived from <typeparamref name="T"/>) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those, if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Catch<T>(this Action lambda,
        Action<ExceptionDispatchInfo, T> errorHandler,
        Action? finallyClause = null)
        where T : Exception
    {
        try
        {
            lambda();
        }
        catch (T e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// derived from <typeparamref name="TError"/>) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those, if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static T Catch<T, TError>(this Func<T> lambda,
        Func<ExceptionDispatchInfo, TError, T> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return lambda();
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// derived from <typeparamref name="TError"/>) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those, if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<T> Catch<T, TError>(this Func<Task<T>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, T> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda().StartIfNeeded().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// derived from <typeparamref name="TError"/>) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those, if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<T> Catch<T, TError>(this Func<ValueTask<T>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, T> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Finally(this Action lambda,
        Action finallyClause)
    {
        try
        {
            lambda();
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static T Finally<T>(this Func<T> lambda,
        Action finallyClause)
    {
        try
        {
            return lambda();
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<T> Finally<T>(this Func<Task<T>> asyncLambda,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda().StartIfNeeded().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<T> Finally<T>(this Func<ValueTask<T>> asyncLambda,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Finally<T>(this Action<T> lambda,
        T state,
        Action finallyClause)
    {
        try
        {
            lambda(state);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="state">Lambda as well as final clause state</param>
    public static void Finally<T>(this Action<T> lambda,
        Action<T> finallyClause,
        T state)
    {
        try
        {
            lambda(state);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="finallyState">Finally clause state</param>
    public static void Finally<T, TFinal>(this Action<T> lambda,
        T state,
        Action<TFinal> finallyClause,
        TFinal finallyState)
    {
        try
        {
            lambda(state);
        }
        finally
        {
            finallyClause(finallyState);
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static T Finally<T, TState>(this Func<TState, T> lambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return lambda(state);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="state">Lambda as well as finally clause state</param>
    public static T Finally<T, TState>(this Func<TState, T> lambda,
        Action<TState> finallyClause,
        TState state)
    {
        try
        {
            return lambda(state);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">Lambda State type</typeparam>
    /// <typeparam name="TFinal">Finally clause state type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="finallyState">finally clause state</param>
    public static T Finally<T, TState, TFinal>(this Func<TState, T> lambda,
        TState state,
        Action<TFinal> finallyClause,
        TFinal finallyState)
    {
        try
        {
            return lambda(state);
        }
        finally
        {
            finallyClause(finallyState);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<T> Finally<T, TState>(this Func<TState, Task<T>> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda(state).StartIfNeeded().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="state">Lambda as well as finally clause state</param>
    public static async Task<T> Finally<T, TState>(this Func<TState, Task<T>> asyncLambda,
        Action<TState> finallyClause,
        TState state)
    {
        try
        {
            return await asyncLambda(state).StartIfNeeded().ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TFinal">Finally clause state type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda as well as finally clause state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="finallyState">finally clause state</param>
    public static async Task<T> Finally<T, TState, TFinal>(this Func<TState, Task<T>> asyncLambda,
        TState state,
        Action<TFinal> finallyClause,
        TFinal finallyState)
    {
        try
        {
            return await asyncLambda(state).StartIfNeeded().ConfigureAwait(false);
        }
        finally
        {
            finallyClause(finallyState);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<T> Finally<T, TState>(this Func<TState, ValueTask<T>> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="state">Lambda as well as finally clause state</param>
    public static async ValueTask<T> Finally<T, TState>(this Func<TState, ValueTask<T>> asyncLambda,
        Action<TState> finallyClause,
        TState state)
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TFinal">Finally clause state type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda as well as finally clause state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    /// <param name="finallyState">finally clause state</param>
    public static async ValueTask<T> Finally<T, TState, TFinal>(this Func<TState, ValueTask<T>> asyncLambda,
        TState state,
        Action<TFinal> finallyClause,
        TFinal finallyState)
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause(finallyState);
        }
    }
}
