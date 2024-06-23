using System.Runtime.ExceptionServices;

namespace DevFast.Net.Extensions.Etc;

/// <summary>
/// Extension methods to execute lambdas.
/// </summary>
public static class Lambdas
{
    /// <summary>
    /// Executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static void Execute(this Action lambda)
    {
        lambda();
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="T">Output type of the lambda</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    public static T Execute<T>(this Func<T> lambda)
    {
        return lambda();
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/>.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static void Execute<TState>(this Action<TState> lambda,
        TState state)
    {
        lambda(state);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> and returns its results.
    /// </summary>
    /// <typeparam name="TOut">Output type of the lambda</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static TOut Execute<TState, TOut>(this Func<TState, TOut> lambda,
        TState state)
    {
        return lambda(state);
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Execute<TError>(this Action lambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            lambda();
        }
        catch (TError e)
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
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut Execute<TOut, TError>(this Func<TOut> lambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
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
    /// Executes <paramref name="lambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Execute<TState, TError>(this Action<TState> lambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            lambda(state);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Executes <paramref name="lambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="lambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut Execute<TState, TOut, TError>(this Func<TState, TOut> lambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return lambda(state);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
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
    public static void Execute(this Action lambda,
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut Execute<TOut>(this Func<TOut> lambda,
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
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Execute<TState>(this Action<TState> lambda,
        TState state,
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
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut Execute<TState, TOut>(this Func<TState, TOut> lambda,
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
    /// Executes <paramref name="lambda"/> inside try block and
    /// excutes <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static void Execute<TState>(this Action<TState> lambda,
        TState state,
        Action<TState> finallyClause)
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
    /// Executes <paramref name="lambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static TOut Execute<TState, TOut>(this Func<TState, TOut> lambda,
        TState state,
        Action<TState> finallyClause)
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
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async Task ExecuteAsync(this Func<Task> lambda)
    {
        await lambda().Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async ValueTask ExecuteAsync(this Func<ValueTask> lambda)
    {
        await lambda().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async Task ExecuteAsync<TState>(this Func<TState, Task> lambda,
        TState state)
    {
        await lambda(state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async ValueTask ExecuteAsync<TState>(this Func<TState, ValueTask> lambda,
        TState state)
    {
        await lambda(state).ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async Task<TOut> ExecuteAsync<TOut>(this Func<Task<TOut>> lambda)
    {
        return await lambda().Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <param name="lambda">Lambda to execute.</param>
    public static async ValueTask<TOut> ExecuteAsync<TOut>(this Func<ValueTask<TOut>> lambda)
    {
        return await lambda().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TOut">Output type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async Task<TOut> ExecuteAsync<TState, TOut>(this Func<TState, Task<TOut>> lambda,
        TState state)
    {
        return await lambda(state).Run().ConfigureAwait(false);
    }

    /// <summary>
    /// Executes the given <paramref name="lambda"/> asynchronously.
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TOut">Output type</typeparam>
    /// <param name="lambda">Lambda to execute.</param>
    /// <param name="state">Lambda state</param>
    public static async ValueTask<TOut> ExecuteAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> lambda,
        TState state)
    {
        return await lambda(state).ConfigureAwait(false);
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteAsync<TError>(this Func<Task> asyncLambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda().Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteAsync<TError>(this Func<ValueTask> asyncLambda,
        Action<ExceptionDispatchInfo, TError> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteAsync<TState, TError>(this Func<TState, Task> asyncLambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteAsync<TState, TError>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action<ExceptionDispatchInfo, TError, TState> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
        }
        catch (TError e)
        {
            errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteAsync<TOut, TError>(this Func<Task<TOut>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda().Run().ConfigureAwait(false);
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
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteAsync<TOut, TError>(this Func<ValueTask<TOut>> asyncLambda,
        Func<ExceptionDispatchInfo, TError, TOut> errorHandler,
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
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteAsync<TState, TOut, TError>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value.
    /// If any exception of type <typeparamref name="TError"/> (or
    /// its derived types) occurs during <paramref name="asyncLambda"/>
    /// execution, relevant information is passed to <paramref name="errorHandler"/>
    /// to obtain the return value.
    /// If any <paramref name="finallyClause"/> is provided, it will be executed inside finally.
    /// <para>
    /// NOTE: The code itself will NOT re-throw caught exception, but,
    /// <paramref name="errorHandler"/> may itself re-throw those (e.g.
    /// <see cref="ExceptionDispatchInfo.Throw()"/>), if needed.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <typeparam name="TError">Exception type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="errorHandler">Error handler to invoke inside catch clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteAsync<TState, TOut, TError>(this Func<TState, ValueTask<TOut>> asyncLambda,
        TState state,
        Func<ExceptionDispatchInfo, TError, TState, TOut> errorHandler,
        Action? finallyClause = null)
        where TError : Exception
    {
        try
        {
            return await asyncLambda(state).ConfigureAwait(false);
        }
        catch (TError e)
        {
            return errorHandler(ExceptionDispatchInfo.Capture(e), e, state);
        }
        finally
        {
            finallyClause?.Invoke();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteAsync(this Func<Task> asyncLambda,
        Action finallyClause)
    {
        try
        {
            await asyncLambda().Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteAsync(this Func<ValueTask> asyncLambda,
        Action finallyClause)
    {
        try
        {
            await asyncLambda().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteAsync<TState>(this Func<TState, Task> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteAsync<TState>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
        }
        finally
        {
            finallyClause();
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task ExecuteAsync<TState>(this Func<TState, Task> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            await asyncLambda(state).Run().ConfigureAwait(false);
        }
        finally
        {
            finallyClause(state);
        }
    }

    /// <summary>
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask ExecuteAsync<TState>(this Func<TState, ValueTask> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            await asyncLambda(state).ConfigureAwait(false);
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteAsync<TOut>(this Func<Task<TOut>> asyncLambda,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda().Run().ConfigureAwait(false);
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteAsync<TOut>(this Func<ValueTask<TOut>> asyncLambda,
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
    /// Asynchronously executes <paramref name="asyncLambda"/> inside try block and returns its value
    /// after excuting <paramref name="finallyClause"/> inside finally.
    /// <para>
    /// NOTE: The code itself will NOT catch any <see cref="Exception"/>.
    /// </para>
    /// </summary>
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Action finallyClause)
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async Task<TOut> ExecuteAsync<TState, TOut>(this Func<TState, Task<TOut>> asyncLambda,
        TState state,
        Action<TState> finallyClause)
    {
        try
        {
            return await asyncLambda(state).Run().ConfigureAwait(false);
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
    /// <typeparam name="TOut">Return type</typeparam>
    /// <typeparam name="TState">State type</typeparam>
    /// <param name="asyncLambda">Lambda to execute inside try clause</param>
    /// <param name="state">Lambda state</param>
    /// <param name="finallyClause">Code to run inside finally clause</param>
    public static async ValueTask<TOut> ExecuteAsync<TState, TOut>(this Func<TState, ValueTask<TOut>> asyncLambda,
        TState state,
        Action<TState> finallyClause)
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
}